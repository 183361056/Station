using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Station
{
    public partial class FrFinger : Form
    {
        private int ans = 0;

        private const int LIVESCAN_SUCCESS = 1;
        private const int BMP_HEAD_SIZE = 1078;
        private const int FPRIMG_MAX_SIZE = 256 * 360;
        private Byte[] FPRawData = new Byte[FPRIMG_MAX_SIZE];
        private Byte[] g_FPBmpData = new Byte[BMP_HEAD_SIZE + FPRIMG_MAX_SIZE];

        private Thread ThFp = null;
        private static ManualResetEvent mrv_fp = new ManualResetEvent(false);

        public FrFinger()
        {
            InitializeComponent();
        }

        public void InitUI()
        {
            toolStripStatus.Text = "";

            BtnFPLeft.Tag = "idle";
            BtnFPLeft.Text = "左手拇指";

            BtnFPRight.Tag = "idle";
            BtnFPRight.Text = "右手拇指";

            LaInfo.Text = "";
        }

        private void StartFPThread(string fingerName)
        {
            ThFp = new Thread(new ParameterizedThreadStart(GetFP));
            ThFp.Start(fingerName);
            ThFp.IsBackground = true;
            if (!ThFp.IsAlive)
            {
                Thread.Sleep(100);
            }
        }

        public void GetFP(object fingerName)
        {
            int ret;
            byte pnScore = 0;
            byte[] FPcharDatatemp = new byte[512];
            byte[] FPcharFPtemp = new byte[512];

            byte[] pszDesc = new byte[1024];
     
            while(true)
            {


                this.Invoke((EventHandler)(delegate { toolStripStatus.Text = Global.errorinfo(10);  }));
               

                ret = Fingerdll.LIVESCAN_Init();
                if (ret != LIVESCAN_SUCCESS)
                {
                  
                    this.Invoke((EventHandler)(delegate { toolStripStatus.Text = Global.errorinfo(12); }));

                    Thread.Sleep(1000);
                    break;
                }
                ret = Fingerdll.LIVESCAN_GetDesc(ref pszDesc[0]);
                if (ret != 1) break;

                string infostr = Encoding.Unicode.GetString(pszDesc);

                if (pszDesc[0] != 65 && pszDesc[0] != 43)
                {
                    this.Invoke((EventHandler)(delegate { toolStripStatus.Text = Global.errorinfo(12); }));
                    break;
                }
                ret = Fingerdll.LIVESCAN_BeginCapture(0);
                if (ret != LIVESCAN_SUCCESS) break;
                ret = Fingerdll.LIVESCAN_GetFPRawData(0, ref FPRawData[0]);
                if (ret != LIVESCAN_SUCCESS) break;

                Global.WriteHead(ref g_FPBmpData, FPRawData, 256, 360);

                if(fingerName.ToString()=="Left")
                {
                    ShowFPBmpData(g_FPBmpData, g_FPBmpData.Length, Application.StartupPath+@"\FingerLeft.bmp", Pbleftfp);
                }
                else
                {
                    ShowFPBmpData(g_FPBmpData, g_FPBmpData.Length, Application.StartupPath+@"\FingerRight.bmp", Pbrightfp);
                }
                
                ret = Fingerdll.LIVESCAN_EndCapture(0);
                if (ret != LIVESCAN_SUCCESS) break;

                ret = Fingerdll.FP_Begin();
                ret = Fingerdll.FP_GetQualityScore(ref FPRawData[0], ref pnScore);
                ret = Fingerdll.FP_End();

                if (fingerName.ToString() == "Left")
                {
                    this.Invoke((EventHandler)(delegate { LaLeftFp.Text = pnScore.ToString(); }));
                }
                else
                {
                    this.Invoke((EventHandler)(delegate { LaRightFp.Text = pnScore.ToString(); }));
                }

                if (pnScore >= Global.FingerScore)
                {

                    this.Invoke((EventHandler)(delegate { toolStripStatus.Text = "指纹采集完成"; }));

                    if (fingerName.ToString() == "Left")
                    {
                         Global.fingerLeftBmp = Application.StartupPath + @"\FingerLeft.bmp";
   
                        this.Invoke((EventHandler)(delegate { ResetFPState(0); }));
                    }
                    else
                    {
                        Global.fingerRightBmp = Application.StartupPath + @"\FingerRight.bmp";

                        this.Invoke((EventHandler)(delegate { ResetFPState(1); }));
                    }

                    break;
                }
               

            }
            
        }



        public  void ShowFPBmpData(byte[] FPBmpData, int dataLen, string bmpFileName, PictureBox FORM_P)
        {
            FileStream file = File.Open(bmpFileName, FileMode.Create);//初始化文件流

            file.Write(FPBmpData, 0, dataLen);//将字节数组写入文件流
            file.Close();//关闭流
            file.Dispose();
            this.Invoke((EventHandler)(delegate
            {
                FileStream pFileStream = new FileStream(bmpFileName, FileMode.Open, FileAccess.Read);
                FORM_P.Image = Image.FromStream(pFileStream);
                pFileStream.Close();
                pFileStream.Dispose();

            }
             ));
        }



        private void ResetFPState(int key)
        {

            if (key == 0)
            {
                BtnFPLeft.Tag = "idle";
                BtnFPLeft.Text = "左手拇指";

                BtnFPRight.Enabled = true;
                BtnFPRight.Tag = "idle";
                BtnFPRight.Text = "右手拇指";
            }
            else
            {
                BtnFPRight.Tag = "idle";
                BtnFPRight.Text = "右手拇指";

                BtnFPLeft.Enabled = true;
                BtnFPLeft.Tag = "idle";
                BtnFPLeft.Text = "左手拇指";
            }
        }

        private void SetFPState(int key)
        {

            if (key == 0)
            {
                BtnFPLeft.Tag = "collect";
                BtnFPLeft.Text = "取消采集";

                BtnFPRight.Enabled = false;
                BtnFPRight.Tag = "idle";
                BtnFPRight.Text = "右手拇指";
            }
            else
            {
                BtnFPRight.Tag = "collect";
                BtnFPRight.Text = "取消采集";

                BtnFPLeft.Enabled = false;
                BtnFPLeft.Tag = "idle";
                BtnFPLeft.Text = "左手拇指";
            }
        }

        private void BtnFPLeft_Click(object sender, EventArgs e)
        {
            if (BtnFPLeft.Tag.ToString() == "collect")
            {
                ResetFPState(0);
            }
            else
            {

                SetFPState(0);
                StartFPThread("Left");

            }
        }

        private void BtnFPRight_Click(object sender, EventArgs e)
        {
            if (BtnFPRight.Tag.ToString() == "collect")
            {
                ResetFPState(1);
            }
            else
            {

                SetFPState(1);
                StartFPThread("Right");

            }
        }


        private unsafe void clearinfo()
        {
    

            Global.fingerLeftBmp = "";
            Global.fingerRightBmp = "";

            if (Pbleftfp.Image != null)
            {
                Pbleftfp.Image.Dispose();
                Pbleftfp.Image = null;
            }


            if (Pbrightfp.Image != null)
            {
                Pbrightfp.Image.Dispose();
                Pbrightfp.Image = null;
            }

            this.Invoke((EventHandler)(delegate { ; }));

        }

        private void FrFinger_Load(object sender, EventArgs e)
        {

            ans = Carddll.InitComm(Global.Port);
            if (ans != 1)
            {
                MessageBox.Show(Global.msg_error(1));
                this.Close();
            }


            InitUI();
        }

        private void FrFinger_FormClosed(object sender, FormClosedEventArgs e)
        {
            ans = Carddll.CloseComm();
            if (ans != 1)
            {
                MessageBox.Show(Global.msg_error(3));
                return;

            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            clearinfo();
            Global.temp_frcard_instance = false;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {

            if (Global.fingerLeftBmp != "" && Global.fingerRightBmp != "")
            {
                FrUsbCapture capture = new FrUsbCapture();
                capture.Show();

                if (Pbleftfp.Image != null)
                {
                    Pbleftfp.Image.Dispose();
                    Pbleftfp.Image = null;
                }


                if (Pbrightfp.Image != null)
                {
                    Pbrightfp.Image.Dispose();
                    Pbrightfp.Image = null;
                }

                this.Close();
            }
            else
            {
                LaInfo.Text="请采集指纹.....";

            }

           
        }
    }
}
