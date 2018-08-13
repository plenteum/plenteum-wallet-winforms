using System;
using System.IO;
using System.Windows.Forms;

namespace PlenteumWallet
{
    public abstract class LogBase
    {
        protected readonly object lockObj = new object();

        public abstract void Log(object obj, string message);
    }

    public class FileLogger : LogBase
    {
        public readonly string filePath = "ple.log";

        public override void Log(object obj, string message)
        {
            lock (lockObj)
            {
                using (StreamWriter streamWriter = new StreamWriter(filePath))
                {
                    streamWriter.WriteLine("[" + DateTime.Now.ToString() + "] - " + message);
                    streamWriter.Close();
                }
            }
        }
    }

    public class WindowLogger : LogBase
    {
        public override void Log(object obj,string message)
        {
            lock (lockObj)
            {
                System.Windows.Forms.TextBox tb = (System.Windows.Forms.TextBox)obj;
                tb.BeginInvoke((MethodInvoker)delegate () 
                {
                    tb.AppendText(message + Environment.NewLine);
                });
            }
        }
    }

}
