using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;


namespace Station
{
    class Carddll
    {
        [DllImport("termb.dll")]
        public unsafe static extern int InitComm(int port);    
        [DllImport("termb.dll")]
        public unsafe static extern int InitCommExt();  
        [DllImport("termb.dll")]
        public unsafe static extern int CloseComm();  
        [DllImport("termb.dll")]
        public unsafe static extern int Authenticate();  
        [DllImport("termb.dll")]
        public unsafe static extern int AuthenticateExt();  
        [DllImport("termb.dll")]
        public unsafe static extern int Read_Content(int active);  
        [DllImport("termb.dll")]
        public unsafe static extern int Read_Content_Path(ref char cPath,int active);  
        [DllImport("termb.dll")]
        public unsafe static extern int GetDeviceID(ref byte pMsg );  
        [DllImport("termb.dll")]
        public unsafe static extern string GetSAMID();  
        [DllImport("termb.dll")]
        public unsafe static extern int GetPhoto(ref char Wlt_File );  
        [DllImport("termb.dll")]
        public unsafe static extern int MfrInfo(ref char cDeviceType,ref char  cDeviceCategory, ref char cDeviceName,ref char cMfr);  

    }
}
