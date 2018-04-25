using System;

namespace Station
{
    public class LogHelper
    {
        private static string logPath = string.Empty;
            public static string LogPath
            {
                get
                {
                    if (logPath == string.Empty)
                    {
                        logPath = AppDomain.CurrentDomain.BaseDirectory+@"\log\";
                    }
                    return logPath;
                }
                set { logPath = value; }
            }

               public static void WriteLog(string logFile, string msg)
            {
                try
                {
                    System.IO.StreamWriter sw = System.IO.File.AppendText(
                        LogPath +logFile + "-" + 
                        DateTime.Now.ToString("yyyyMMdd") + ".Log"
                        );
                    sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss: ") + msg);
                    sw.Close();
                }
                catch
                { }
            }

            /// <summary>
            /// 写日志
            /// </summary>
            public static void WriteLog(LogFile logFile, string msg)
            {
                WriteLog(logFile.ToString(), msg);
            }
      }

/// <summary>
/// 日志类型
/// </summary>
                public enum LogFile
                {
                    Trace,
                    Warning,
                    Error,
                    SQL
                }
    
}
