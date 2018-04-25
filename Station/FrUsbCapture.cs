using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using System.Threading;
using Emgu.CV.Util;
using System.IO;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Timers;

namespace Station
{
    public partial class FrUsbCapture : Form
    {

        private VideoCapture _capture = null;
        private Mat _frame;
        private Image<Bgr, byte> Sub = null;

        long detectionTime=0;
        List<Rectangle> faces = new List<Rectangle>();
        List<Rectangle> eyes = new List<Rectangle>();

        List<Rectangle> exfaces = new List<Rectangle>();

        private Image<Bgr, Byte> image  = null;
        Rectangle exface ;
        Mat mat_face = null;

        public FrUsbCapture()
        {
            InitializeComponent();
     
            CvInvoke.UseOpenCL = false;

            try
            {
                _capture = new VideoCapture();

                //_capture.SetCaptureProperty(CapProp.FrameHeight, 1080);
                //_capture.SetCaptureProperty(CapProp.FrameWidth, 1920);

                _capture.ImageGrabbed += ProcessFrame;
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }

            _frame = new Mat();

            BtnNext.Enabled = false;
           
        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            if (_capture != null && _capture.Ptr != IntPtr.Zero)
            {

                _capture.Retrieve(_frame, 0);


                if (_frame != null)
                {

                    image = _frame.ToImage<Bgr, byte>();

                    if (image != null)
                    {

                        faces.Clear();
                        eyes.Clear();

                        DetectFace.Detect(
                           image, @"haarcascades\haarcascade_frontalface_default.xml", @"haarcascades\haarcascade_eye.xml",
                          faces, eyes,
                          out detectionTime);

                        foreach (Rectangle face in faces)
                        {

                            if(face.Width*face.Height*3>60*1024)
                            {

                        

                            exface = face;
                            exface.X -= 20;
                            exface.Y -= 20;
                            exface.Height += 40;
                            exface.Width += 40;                          

                            try
                            {
                             //   CvInvoke.Rectangle(image, exface, new Bgr(Color.Red).MCvScalar, 2);

                                exface.X += 2;
                                exface.Y += 2;
                                exface.Height -= 3;
                                exface.Width -= 3;

                                Sub = image.GetSubRect(exface);
                                imageFace.BackgroundImage = Sub.ToBitmap();
                                imageFace.BackgroundImageLayout = ImageLayout.Stretch;

                            }
                            catch
                            {

                            }

                            }

                        }
                    }

                   
                    captureImageBox.BackgroundImage= image.ToBitmap();

                }
            }
        }

      

        private void ReleaseData()
        {
            if (_capture != null)
                _capture.Dispose();
        }

        private void FrUsbCapture_Load(object sender, EventArgs e)
        {
            if (_capture != null)
            {
                _capture.Start();
            }
        }

        private void FrUsbCapture_FormClosed(object sender, FormClosedEventArgs e)
        {
            _capture.Stop();
            ReleaseData();
        }

        private void BtCapture_Click(object sender, EventArgs e)
        {
            string temp = DateTime.Now.ToString("yyyyMMddHHmmssffff");

            if (captureImageBox.BackgroundImage != null)
            {
                string BigFileName = Application.StartupPath + @"\big.jpg";
                captureImageBox.BackgroundImage.Save(BigFileName);

                Global.bigImage = BigFileName;
              
            }

            if (imageFace.BackgroundImage!=null)
            {
                string SmallPicFileName = Application.StartupPath + @"\small.jpg";
                imageFace.BackgroundImage.Save(SmallPicFileName);

                Global.smallImage = SmallPicFileName;

                BtnNext.Enabled = true;
            }

            

        }

        private unsafe void clearinfo()
        {


            Global.bigImage = "";
            Global.smallImage = "";

            if (captureImageBox.BackgroundImage != null)
            {
                captureImageBox.BackgroundImage.Dispose();
                captureImageBox.BackgroundImage = null;
            }


            if (imageFace.BackgroundImage != null)
            {
                imageFace.BackgroundImage.Dispose();
                imageFace.BackgroundImage = null;
            }
            this.Invoke((EventHandler)(delegate {; }));

        }
        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (captureImageBox.BackgroundImage != null)
            {
                captureImageBox.BackgroundImage.Dispose();
                captureImageBox.BackgroundImage = null;
            }


            if (imageFace.BackgroundImage != null)
            {
                imageFace.BackgroundImage.Dispose();
                imageFace.BackgroundImage = null;
            }

            FrIDCardSave cardsave = new FrIDCardSave();
            cardsave.Show();

            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            clearinfo();

            Global.temp_frcard_instance = false;

            this.Close();
        }
    }
}
