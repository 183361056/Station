using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
namespace Station
{
    class Fingerdll
    {

        [DllImport("ID_FprCap.dll")]
        public unsafe static extern int LIVESCAN_Init();    //打开与设备的连接	 成功与否(1=成功;非1代表错误码
        [DllImport("ID_FprCap.dll")]
        public unsafe static extern int LIVESCAN_Close();   //关闭与设备的连接 成功与否(1=成功;非1代表错误码
        [DllImport("ID_FprCap.dll")]
        public unsafe static extern int LIVESCAN_GetChannelCount();   //获取通道总数 成功与否(1=成功;非1代表错误码
        [DllImport("ID_FprCap.dll")]
        public unsafe static extern int LIVESCAN_SetBright(int nChannel, int nBright);              //设置当前亮度	 成功与否(1=成功;非1代表错误码
        [DllImport("ID_FprCap.dll")]
        public unsafe static extern int LIVESCAN_SetContrast(int nChannel, int nContrast);          //设置对比度       成功与否(1=成功;非1代表错误码
        [DllImport("ID_FprCap.dll")]
        public unsafe static extern int LIVESCAN_GetBright(int nChannel, ref int pnBright);         // 获取当前亮度 成功与否(1=成功;非1代表错误码
        [DllImport("ID_FprCap.dll")]
        public unsafe static extern int LIVESCAN_GetContrast(int nChannel, ref int pnContrast);     // 获取当前对比度 成功与否(1=成功;非1代表错误码
        [DllImport("ID_FprCap.dll")]
        public unsafe static extern int LIVESCAN_GetMaxImageSize(int nChannel, ref int pnWidth, ref int pnHeight);     // 获取当前对比度 成功与否(1=成功;非1代表错误码
        [DllImport("ID_FprCap.dll")]
        public unsafe static extern int LIVESCAN_GetCaptWindow(int nChannel, ref int pnOriginX, ref int pnOriginY, ref int pnWidth, ref int pnHeight);      // 获得当前的窗口位置 成功与否(1=成功;非1代表错误码
        [DllImport("ID_FprCap.dll")]
        public unsafe static extern int LIVESCAN_SetCaptWindow(int nChannel, ref int nOriginX, ref int nOriginY, ref int nWidth, ref int nHeight);          // 设置当前的窗口位置 成功与否(1=成功;非1代表错误码
        [DllImport("ID_FprCap.dll")]
        public unsafe static extern int LIVESCAN_Setup();                                           //调用设置对话框	 成功与否(1=成功;非1代表错误码
        [DllImport("ID_FprCap.dll")]
        public unsafe static extern int LIVESCAN_BeginCapture(int nChannel);                        //开始采集	 成功与否(1=成功;非1代表错误码
        [DllImport("ID_FprCap.dll")]
        public unsafe static extern int LIVESCAN_GetFPRawData(int nChannel, ref Byte pRawData);     //获取图像RAW数据并显示出来	 成功与否(1=成功;非1代表错误码
        [DllImport("ID_FprCap.dll")]
        public unsafe static extern int LIVESCAN_GetFPBmpData(int nChannel, ref Byte pRawData);     //获取图像BMP数据并显示出来	 成功与否(1=成功;非1代表错误码
        [DllImport("ID_FprCap.dll")]
        public unsafe static extern int LIVESCAN_EndCapture(int nChannel);                          //结束采集	 成功与否(1=成功;非1代表错误码
        [DllImport("ID_FprCap.dll")]
        public unsafe static extern int LIVESCAN_IsSupportSetup();                      //	 成功与否(1=成功;非1代表错误码
        [DllImport("ID_FprCap.dll")]
        public unsafe static extern int LIVESCAN_GetVersion();                      //	 成功与否(1=成功;非1代表错误码
        [DllImport("ID_FprCap.dll")]
        public unsafe static extern int LIVESCAN_GetDesc(ref byte pszDesc);                      //	 成功与否(1=成功;非1代表错误码
        [DllImport("ID_FprCap.dll")]
        public unsafe static extern int LIVESCAN_GetErrorInfo(int nErrorNo, ref Byte pszDesc);       //	 成功与否(1=成功;非1代表错误码
        [DllImport("ID_FprCap.dll")]
        public unsafe static extern int LIVESCAN_SetBufferEmpty(ref byte pImageData, long imageLength);       //	 成功与否(1=成功;非1代表错误码
        [DllImport("ID_FprCap.dll")]
        public unsafe static extern int LIVESCAN_SetGamma(int nChannel, int nGamma);       //	 成功与否(1=成功;非1代表错误码
        [DllImport("ID_FprCap.dll")]
        public unsafe static extern int LIVESCAN_SetID(int nChannel, ref byte IDData);       //	 成功与否(1=成功;非1代表错误码

        [DllImport("ID_Fpr.dll")]
        public unsafe static extern int FP_Begin();       //	 

        [DllImport("ID_Fpr.dll")]
        public unsafe static extern int FP_GetQualityScore(ref byte   pFingerImgBuf, ref byte pnScore);       //	 成功与否(1=成功;非1代表错误码

        [DllImport("ID_Fpr.dll")]
        public unsafe static extern int FP_FeatureExtract(byte  cScannerType, //输入参数 指纹采集器类型代码
										  byte   cFingerCode,	 // 指位代码。输入参数。
										   ref byte pFingerImgBuf,//输入参数 指纹图像数据指针 图像格式为256(width)*360(height) 8位灰度图像 
										   ref byte pFeatureData);       //	 成功与否(1=成功;非1代表错误码

        [DllImport("ID_Fpr.dll")]
        public unsafe static extern int FP_FeatureMatch(ref byte pFeatureData1,	//输入参数 指纹特征数据1
										 ref byte pFeatureData2,	//输入参数 指纹特征数据2
										 ref float pfSimilarity);       //	 成功与否(1=成功;非1代表错误码


        [DllImport("ID_Fpr.dll")]
        public unsafe static extern int FP_End();       //	

    }
}
