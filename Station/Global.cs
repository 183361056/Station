using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace Station
{
    public class Global
    {

        public static string ConnectionString = "User Id=card;Password=card;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=117.36.77.242)(PORT=9090)))(CONNECT_DATA=(SERVICE_NAME=orcl)))";

        public static string userid = "";
        public static string username = "";
        public static string commid = "";
        public static string commname = "";

        public static int Port=1001;

        public static string fullname = "";
        public static string sex = "";
        public static string nation = "";
        public static string birthDate = "";
        public static string birthDateTmp = "";
        public static string address = "";
        public static string IDN = "";
        public static string regDept = "";
        public static string ValidDatetmp = "";
        public static string validBeginDate = "";
        public static string validEndDate = "";
        public static int fingerCount = 0;
        public static string fingerDesc = "";

        public static string fingerLeftBmp = "";
        public static string fingerRightBmp = "";


        public static string bigImage = "";
        public static string smallImage = "";

        public static string buildingno = "";
        public static string unitno;
        public static string roomno;
        public static string floors;
        public static string rooms;
        public static string workplace;
        public static string housetype;
        public static string purpose;
        public static string usestatus;
        public static string contactway;
  


        public static float FingerScore = 75;





        /// ///////////////////////临时变量////////////////////////////

        public static bool temp_frcard_instance = false;

        public static string temp_building_unit = "";    


        public enum fpstate {left,right,idle};

        
        public static void InitApp() 
        {

             FileInfo fi = new FileInfo(Application.StartupPath + @"\zp.bmp");
            if(fi.Exists)
            {
                fi.Delete();
            }

            fi = new FileInfo(Application.StartupPath + @"\small.jpg");
            if(fi.Exists)
            {
                fi.Delete();
            }

            fi = new FileInfo(Application.StartupPath + @"\big.jpg");
            if (fi.Exists)
            {
                fi.Delete();
            }

            fi = new FileInfo(Application.StartupPath + @"\FingerLeft.bmp");
            if (fi.Exists)
            {
                fi.Delete();
            }


            fi = new FileInfo(Application.StartupPath + @"\FingerRight.bmp");
            if (fi.Exists)
            {
                fi.Delete();
            }
        }


        public static int WriteHead(ref byte[] Output, byte[] Input, int nWidth, int nHeight)
        {
            int IMAGE_X = nWidth, IMAGE_Y = nHeight;
            byte[] head = new byte[1078];
            byte[] head1 = new byte[]{ 0x42,0x4d,//file type  
			        //0x36,0x6c,0x01,0x00, //file size***
			        0x0,0x0,0x0,0x00, //file size***
			        0x00,0x00, //reserved
			        0x00,0x00,//reserved
			        0x36,0x4,0x00,0x00,//head  byte***  bfOffBits
			        /***************************/
			        //infoheader
			        0x28,0x00,0x00,0x00,//struct size
        			
			        //0x00,0x01,0x00,0x00,//map width*** 
			        0x00,0x00,0x0,0x00,//map width*** 
			        //0x68,0x01,0x00,0x00,//map height***
			        0x00,0x00,0x00,0x00,//map height***
        			
			        0x01,0x00,//must be 1
			        0x08,0x00,//color count***
			        0x00,0x00,0x00,0x00, //compression
			        //0x00,0x68,0x01,0x00,//data size***
			        0x00,0x00,0x00,0x00,//data size***
			        0x00,0x00,0x00,0x00, //dpix
			        0x00,0x00,0x00,0x00, //dpiy
			        0x00,0x00,0x00,0x00,//color used
			        0x00,0x00,0x00,0x00,//color important
        			
	        };
            for (int z = 0; z < head1.Length; z++)
            {
                head[z] = head1[z];
            }

            long num;
            num = IMAGE_X; head[18] = (byte)(num & 0xFF);
            num = num >> 8; head[19] = (byte)(num & 0xFF);
            num = num >> 8; head[20] = (byte)(num & 0xFF);
            num = num >> 8; head[21] = (byte)(num & 0xFF);


            num = IMAGE_Y; head[22] = (byte)(num & 0xFF);
            num = num >> 8; head[23] = (byte)(num & 0xFF);
            num = num >> 8; head[24] = (byte)(num & 0xFF);
            num = num >> 8; head[25] = (byte)(num & 0xFF);

            int i, j;

            j = 0;
            for (i = 54; i < 1078; i = i + 4)
            {
                head[i] = head[i + 1] = head[i + 2] = (byte)j;
                head[i + 3] = 0;
                j++;
            }

            byte[] newdata = new byte[256 * 360 + 1078];
            head.CopyTo(Output, 0);
            head.CopyTo(newdata, 0);

            Input.CopyTo(newdata, 1078);

            for (int z = 0; z < 360; z++)
            {
                for (int t = 0; t < 256; t++)
                {
                    Output[1078 + 256 * (360 - z - 1) + t] = newdata[1078 + 256 * z + t];
                }

            }

            return 1;
        }


        /***************************
        * FPbmpDATA显示图像
        * 
        ***************** */


        public static string errorinfo(int errortype)
        {
            string errorstr = "";
            switch (errortype)
            {
                case 1:  errorstr = "读卡成功!请放下一张卡..."; break;
                case 3:  errorstr = "读卡成功!请放下一张卡..."; break;
                case -1: errorstr = "相片解码错误!"; break;
                case -2: errorstr = "wlt文件后缀错误!"; break;
                case -3: errorstr = " wlt文件打开错误!"; break;
                case -4: errorstr = "wlt文件格式错误!"; break;
                case -5: errorstr = "软件未授权!"; break;
                case -11: errorstr = "无效参数!"; break;
                case -12: errorstr = "正在读卡..."; break;
                case -13: errorstr = "请刷卡..."; break;

                case 10: errorstr = "请按捺指纹..."; break;
                case 11: errorstr = "指纹获取成功"; break;
                case 12: errorstr = "请插入指纹设备"; break;




                default: errorstr = "卡认证错误!"; break;
            }
            return errorstr;

        }

        public static void GetNation(string nationtemp)
        {
            string[] nationarray = new string[56]{"汉", "蒙古", "回", "藏", "维吾尔", "苗", "彝", "壮", "布依", "朝鲜",
                        "满", "侗", "瑶", "白", "土家", "哈尼", "哈萨克", "傣", "黎", "傈僳",
                        "佤", "畲", "高山", "拉祜", "水", "东乡", "纳西", "景颇", "柯尔克孜", "土",
                        "达斡尔", "仫佬", "羌", "布朗", "撒拉", "毛南", "仡佬", "锡伯", "阿昌", "普米",
                        "塔吉克", "怒", "乌孜别克", "俄罗斯", "鄂温克", "德昂", "保安", "裕固", "京", "塔塔尔",
                        "独龙", "鄂伦春", "赫哲", "门巴", "珞巴", "基诺"}; ;
            if (nationtemp != "")
            {
                int temp = 0;
                temp = Convert.ToInt32(nationtemp);
                if (temp >= 1 && temp <= 56)
                {
                    Global.nation = nationarray[temp - 1];
                }
                else
                {
                    Global.nation = "未知";
                }
            }
            else
            {
                Global.nation= "未知";
            }
        }
        public static string Getfpcode(int havefp,byte[] fpcode)
        {
            string fpstr = "指位:";
            for (int i = 0; i < havefp; i++)
            {
                switch (fpcode[i * 2])
                {
                    case 11: fpstr += "右手拇指、"; break;
                    case 12: fpstr += "右手食指、"; break;
                    case 13: fpstr += "右手中指、"; break;
                    case 14: fpstr += "右手环指、"; break;
                    case 15: fpstr += "右手小指、"; break;

                    case 16: fpstr += "左手拇指、"; break;
                    case 17: fpstr += "左手食指、"; break;
                    case 18: fpstr += "左手中指、"; break;
                    case 19: fpstr += "左手环指、"; break;
                    case 20: fpstr += "左手小指、"; break;

                    case 97: fpstr += "右手不确定指、"; break;
                    case 98: fpstr += "左手不确定指、"; break;
                    case 99: fpstr += "不确定指、"; break;

                    default: break;
                }
                if (i % 4 == 3)
                {
                    fpstr += "\r\n              ";
                }

            }
            string strtemp = "";
            strtemp = fpstr.Substring(0, fpstr.Length - 1);
            strtemp += "\r\n";
            return strtemp;

        }







        public static string msg_error(int errortype)
        {
            string errorstr = "";
            switch (errortype)
            {
                case 0: errorstr = "成功"; break;
                case 1: errorstr = "请连接设备"; break;
                case 2: errorstr = "请刷卡"; break;
                case 3: errorstr = "设备忙"; break;
                default: break;
            }
            return errorstr;
        }

        public static Image BytesToImage(Byte[] buffer)
        {
            var ms = new MemoryStream(buffer, 0, buffer.Length);
            var bf = new BinaryFormatter();
            object obj = bf.Deserialize(ms);
            ms.Close();
            return (Image)obj;
        }
        /// <summary>
        /// 图片转换为字节数组
        /// </summary>
        /// <param name="image">图片</param>
        /// <returns>字节数组</returns>
        public static byte[] ImageToBytes(Image image)
        {
            var ms = new MemoryStream();
            var bf = new BinaryFormatter();
            bf.Serialize(ms, image);
            ms.Close();
            return ms.ToArray();
        }


        public static byte[] ImageToBytes(string filepath)
        {
            Image image = Image.FromFile(filepath);
            var ms = new MemoryStream();
            var bf = new BinaryFormatter();
            bf.Serialize(ms, image);
            ms.Close();
            return ms.ToArray();
        }

    }
}
