using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsvEditor
{
    class Log
    {
        public static string dir = Application.StartupPath;
        public static string path = Path.Combine(dir, "log.txt");

        public static void Write(string msg)
        {
            StreamWriter sw = null;
            try
            {
                sw = File.AppendText(path);
                sw.WriteLine($"{} :: {msg}");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sw.Close();
            }
        }
    }
}
