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
    public partial class FrIDCard : Form
    {
        private int ans = 0;

        private byte[] penple_fp = new byte[512 * 10];
        private int havefp = 0;
        private byte[] penple_code = new byte[10 * 2];//指位，质量


        private Thread ThCard = null;
        private static ManualResetEvent mrv_card = new ManualResetEvent(false);


        public FrIDCard()
        {
            InitializeComponent();
        }

 


        private void FrIDCard_Load(object sender, EventArgs e)
        {
            ans = Carddll.InitComm(Global.Port);
            if (ans != 1)
            {
                MessageBox.Show(Global.msg_error(1));
                this.Close();
            }

            
            /////////////////////////////////////////////////////

            StartCardThread();

            clearinfo();

            InitControl();
        }
        

        private void InitControl()
        {
            DataSet ds = null;

      
            try
            {

                ds = SqlHelper.ExecuteDataset(Global.ConnectionString, CommandType.Text, " select typename from T_HOUSETYPE ");
                Cbroompurpose.DataSource = ds.Tables[0];
                Cbroompurpose.ValueMember = "typename";
                Cbroompurpose.DisplayMember = "typename";
                Cbroompurpose.SelectedIndex = -1;

                ds = SqlHelper.ExecuteDataset(Global.ConnectionString, CommandType.Text, " select purpose from T_ROOMPURPOSE ");
                Cbhousetype.DataSource = ds.Tables[0];
                Cbhousetype.ValueMember = "purpose";
                Cbhousetype.DisplayMember = "purpose";
                Cbhousetype.SelectedIndex = -1;

                ds = SqlHelper.ExecuteDataset(Global.ConnectionString, CommandType.Text, " select usestatus from T_ROOMUSESTATUS ");
                Cbroomstatus.DataSource = ds.Tables[0];
                Cbroomstatus.ValueMember = "usestatus";
                Cbroomstatus.DisplayMember = "usestatus";
                Cbroomstatus.SelectedIndex = -1;


                LaInfo.Text = "";

            }
            catch
            {
                LaInfo.Text = "数据初始化发生错误！";
            }


        }


        private void StartCardThread()
        {
            ThCard = new Thread(new ThreadStart(getcard));
            ThCard.Start();
            ThCard.IsBackground = true;
            if (!ThCard.IsAlive)
            {
                Thread.Sleep(100);
            }
        }

   


        private unsafe void getcard()
        {
         

            while (true)
            {

                mrv_card.WaitOne();

                Thread.Sleep(500);

                ans = Carddll.Authenticate();
                if (ans != 1)
                {
                    toolStripStatus.Text = errorinfo(-13);                    
                    continue;
                }


                clearinfo();

                toolStripStatus.Text = errorinfo(-12);//错误信息
                ans = Carddll.Read_Content(1);       //读基本信息


                toolStripStatus.Text = errorinfo(ans);//错误信息

                if (ans != 1 && ans != 3)
                {                   
                    continue;
                }

                Display(Application.StartupPath, ans);

                mrv_card.Reset();
                
            }

        }


        
 

        private unsafe void Display(string Apth, int havefinger)
        {
            FileStream fsMyfile = new FileStream(Apth + "\\wz.txt", FileMode.Open, FileAccess.Read);

            BinaryReader brMyfile = new BinaryReader(fsMyfile);
            brMyfile.BaseStream.Seek(0, SeekOrigin.Begin);
            string infostr = "";
            byte[] data1 = new Byte[fsMyfile.Length];

            for (int i = 0; i < fsMyfile.Length; i++)
            { data1[i] = brMyfile.ReadByte(); }


            fsMyfile.Close();
            brMyfile.Close();

            infostr = Encoding.Unicode.GetString(data1);


            Global.fullname = infostr.Substring(0, 14).Trim();
            Global.sex = infostr.Substring(15, 1).Trim();
            switch (Global.sex)
            {
                case "0": Global.sex = "未知"; break;
                case "1": Global.sex = "男"; break;
                case "2": Global.sex = "女"; break;

                default: Global.sex = "未说明"; break;
            }
            Global.nation = infostr.Substring(16, 2).Trim();

            Global.GetNation(Global.nation);

            Global.birthDateTmp = infostr.Substring(18, 8);
            Global.birthDateTmp = Global.birthDateTmp.Substring(0, 4) + "年" + Global.birthDateTmp.Substring(4, 2) + "月" + Global.birthDateTmp.Substring(6, 2) + "日";
            Global.birthDate= Global.birthDateTmp.Substring(0, 4) + "-" + Global.birthDateTmp.Substring(4, 2) + "-" + Global.birthDateTmp.Substring(6, 2) ;

            Global.address = infostr.Substring(26, 20).Trim() + "\r\n" + infostr.Substring(46, 15).Trim();
            Global.IDN = infostr.Substring(61, 18);

            Global.regDept = infostr.Substring(79, 15).Trim();
            Global.ValidDatetmp = infostr.Substring(94, 16);

            if (Global.ValidDatetmp.Substring(8, 2) == "长期")
            {
                Global.validBeginDate = Global.ValidDatetmp.Substring(0, 4) + "-" + Global.ValidDatetmp.Substring(4, 2) + "-" + Global.ValidDatetmp.Substring(6, 2);
                Global.validEndDate= Global.ValidDatetmp.Substring(8, 2);
            }
            else
            {
                Global.validBeginDate = Global.ValidDatetmp.Substring(0, 4) + "-" + Global.ValidDatetmp.Substring(4, 2) + "-" + Global.ValidDatetmp.Substring(6, 2);
                Global.validEndDate = Global.ValidDatetmp.Substring(8, 4) + "-" + Global.ValidDatetmp.Substring(12, 2) + "-" + Global.ValidDatetmp.Substring(14, 2);
            }

            if (Global.ValidDatetmp.Substring(8, 2) == "长期")
            {
                Global.ValidDatetmp = Global.ValidDatetmp.Substring(0, 4) + "." + Global.ValidDatetmp.Substring(4, 2) + "." + Global.ValidDatetmp.Substring(6, 2) + "-" + Global.ValidDatetmp.Substring(8, 2);
            }
            else
            {
                Global.ValidDatetmp = Global.ValidDatetmp.Substring(0, 4) + "." + Global.ValidDatetmp.Substring(4, 2) + "." + Global.ValidDatetmp.Substring(6, 2) + "-" + Global.ValidDatetmp.Substring(8, 4) + "." + Global.ValidDatetmp.Substring(12, 2) + "." + Global.ValidDatetmp.Substring(14, 2);
            }

            this.Invoke((EventHandler)(delegate { label_name.Text = "" + Global.fullname; }));
            this.Invoke((EventHandler)(delegate { label_sex.Text = "" + Global.sex; }));
            this.Invoke((EventHandler)(delegate { label_mz.Text = "" + Global.nation; }));
            this.Invoke((EventHandler)(delegate { label_ch.Text = "" + Global.birthDate; }));
            this.Invoke((EventHandler)(delegate { label_zz.Text = "" + Global.address; }));

            this.Invoke((EventHandler)(delegate { label_sf.Text = "" + Global.IDN; }));
            this.Invoke((EventHandler)(delegate { label_qf.Text = "" + Global.regDept; }));
            this.Invoke((EventHandler)(delegate { label_yx.Text = "" + Global.ValidDatetmp; }));


            this.Invoke((EventHandler)(delegate { PbCardzp.BackgroundImage= new Bitmap(Apth + "\\zp.bmp"); }));


            if (havefinger == 3)
            {

                FileStream fpMyfile = new FileStream(Apth + "\\fp.dat", FileMode.Open, FileAccess.Read);

                BinaryReader bpMyfile = new BinaryReader(fpMyfile);
                bpMyfile.BaseStream.Seek(0, SeekOrigin.Begin);
          
                for (int i = 0; i < fpMyfile.Length; i++)
                {
                    penple_fp[i] = bpMyfile.ReadByte();

                }
                if (fpMyfile.Length > 0)
                {
                    havefp = (int)(fpMyfile.Length / 512);
                }
                for (int j = 0; j < havefp; j++)
                {
                    penple_code[2 * j] = penple_fp[5 + j * 512];
                    penple_code[2 * j + 1] = penple_fp[6 + j * 512];

                }

                Global.fingerCount = havefp;
                Global.fingerDesc = Global.Getfpcode(havefp, penple_code); 
              

                fpMyfile.Close();
                bpMyfile.Close();
                              
            }
            else
            {
                Array.Clear(penple_fp, 0, penple_fp.Length);
                Array.Clear(penple_code, 0, penple_code.Length);
                havefp = 0;


                Global.fingerCount = 0;
                Global.fingerDesc = "";

                this.Invoke((EventHandler)(delegate
                {
                    
                }));
            }

        }

        

        private unsafe void clearinfo()
        {
            this.Invoke((EventHandler)(delegate { label_name.Text = ""; }));
            this.Invoke((EventHandler)(delegate { label_sex.Text = ""; }));
            this.Invoke((EventHandler)(delegate { label_mz.Text = ""; }));
            this.Invoke((EventHandler)(delegate { label_ch.Text = ""; }));
            this.Invoke((EventHandler)(delegate { label_zz.Text = ""; }));

            this.Invoke((EventHandler)(delegate { label_sf.Text = ""; }));
            this.Invoke((EventHandler)(delegate { label_qf.Text = ""; }));
            this.Invoke((EventHandler)(delegate { label_yx.Text = ""; }));



            Global.fullname = "";
            Global.sex = "";
            Global.nation = "";
            Global.birthDate = "";
            Global.birthDateTmp = "";
            Global.address = "";
            Global.IDN = "";
            Global.regDept = "";
            Global.ValidDatetmp = "";
            Global.validBeginDate = "";
            Global.validEndDate = "";

            Global.fingerCount = 0;
            Global.fingerDesc = "";

            if (PbCardzp.Image != null)
            {
                PbCardzp.Image.Dispose();
                PbCardzp.Image = null;
            }


            //this.Invoke((EventHandler)(delegate { textinfo.Text = ""; }));
            //图像清空

            //if (fpbmp.Image != null)
            //{
            //    fpbmp.Image.Dispose();
            //    fpbmp.Image = null;
            //}
            //this.Invoke((EventHandler)(delegate { button_fpmatch.Tag = "指纹比对"; this.button_fpmatch.Image = global::KT_SF_001.Properties.Resources.A33; ; }));




            havefp = 0;  
        }


        private unsafe string errorinfo(int errortype)
        {
            string errorstr = "";
            switch (errortype)
            {
                case 1: this.Invoke((EventHandler)(delegate { label_fp.Text = ""; })); errorstr = "读卡成功!请放下一张卡..."; break;
                case 3: this.Invoke((EventHandler)(delegate { label_fp.Text = ""; })); errorstr = "读卡成功!请放下一张卡..."; break;
                case -1: errorstr = "相片解码错误!"; break;
                case -2: errorstr = "wlt文件后缀错误!"; break;
                case -3: errorstr = " wlt文件打开错误!"; break;
                case -4: errorstr = "wlt文件格式错误!"; break;
                case -5: errorstr = "软件未授权!"; break;
                case -11: errorstr = "无效参数!"; break;
                case -12: errorstr = "正在读卡..."; break;
                case -13: errorstr = "请刷卡(或离开重放)..."; break;

                case 10: errorstr = "请按捺指纹..."; break;
                case 11: errorstr = "指纹获取成功"; break;
                case 12: errorstr = "请插入指纹设备"; break;




                default: errorstr = "卡认证错误!"; break;
            }
            return errorstr;

        }

        private void BtnCard_Click(object sender, EventArgs e)
        {
            mrv_card.Set();
        }


        private bool Check()
        {
            if (Global.IDN == "")
            {
                LaInfo.Text = "请刷二代身份证！";
                return false;
            }

            if(Tbbuildingno.Text=="")
            {
                LaInfo.Text = "楼号不能为空！";
                return false;
            }

            if(Tbunitno.Text=="")
            {
                LaInfo.Text = "单元号不能为空！";
                return false;
            }

            if(Tbroomno.Text=="")
            {
                LaInfo.Text = "房间号不能为空！";
                return false;
            }

            if(Nufloor.Value==0)
            {
                LaInfo.Text = "楼层不能为0！";
                return false;
            }

            if(Nurooms.Value==0)
            {
                LaInfo.Text = "房间数不能为0！";
                return false;
            }

            if(Cbhousetype.Text=="")
            {
                LaInfo.Text = "请选择房屋类型！";
                return false;
            }

            if(Cbroompurpose.Text=="")
            {
                LaInfo.Text = "请选择房屋用途！";
                return false;
            }

            if(Cbroomstatus.Text=="")
            {
                LaInfo.Text = "请选择居住现状！";
                return false;
            }

            if(Tbcontactway.Text=="")
            {
                LaInfo.Text = "联系方式不能为空！";
                return false;
            }

            return true;
        }
        private void BtnNext_Click(object sender, EventArgs e)
        {
           if(Check())
            {


                Global.buildingno = Tbbuildingno.Text;
                Global.unitno = Tbunitno.Text;
                Global.roomno = Tbroomno.Text;
                Global.floors = Nufloor.Value.ToString();
                Global.rooms = Nurooms.Value.ToString();
                Global.workplace = Tbworkplace.Text;
                Global.housetype = Cbhousetype.Text;
                Global.purpose = Cbroompurpose.Text;
                Global.usestatus = Cbroomstatus.Text;
                Global.contactway = Tbcontactway.Text;

                FrFinger finger = new FrFinger();
                finger.Show();

                if (PbCardzp.Image != null)
                {
                    PbCardzp.Image.Dispose();
                    PbCardzp.Image = null;
                }
                this.Close();
            }
        }

        private void FrIDCard_FormClosed(object sender, FormClosedEventArgs e)
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
            this.Close();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            Global.temp_building_unit = "";

            FrBuilding build = new FrBuilding();
            build.ShowDialog();
            build.Dispose();

            if(Global.temp_building_unit!="")
            {
                try
                {
                    Tbbuildingno.Text = Global.temp_building_unit.Split('#')[0];
                    Tbunitno.Text = Global.temp_building_unit.Split('#')[1];
                }
                catch
                {
                    Tbbuildingno.Text = "";
                    Tbunitno.Text = "";
                }
               
            }
        }
    }
}
