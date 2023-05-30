using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace old.Log.Delete
{
    public partial class MainF : Form
    {
        public MainF()
        {
            InitializeComponent();
        }

        public const string _DIR_LOG = @".\Log\";

        private void btn_CreateLogFile_Click(object sender, EventArgs e)
        {
            DateTime sTime = DateTime.ParseExact("2023-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture);

            //DateTime eTime = DateTime.ParseExact("2023-05-25", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime eTime = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);



            string dirPath = Environment.CurrentDirectory + _DIR_LOG;
            string log = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} :: test";

            for (var date = sTime; date <= eTime; date = date.AddDays(1))
            {
                string fileName = string.Format($"{dirPath}\\{date.ToString("yyyyMMdd")}.log");

                if (!new DirectoryInfo(dirPath).Exists) { Directory.CreateDirectory(dirPath); }

                if (!new FileInfo(fileName).Exists)
                {
                    using (StreamWriter sw = new StreamWriter(fileName))
                    {
                        sw.WriteLine(log);
                        sw.Close();
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(fileName))
                    {
                        sw.WriteLine(log);
                        sw.Close();
                    }
                }
            }




            //DateTime dT = DateTime.Now.AddDays(-60);

            //tBox_Log.AppendText($"{dT}\n");


            //string dirPath = Environment.CurrentDirectory + _DIR_LOG;
            ////string fileName = string.Format($"{dirPath}\\{DateTime.Today.ToString("yyyyMMdd")}.log");
            //string fileName = string.Format($"{dirPath}\\{dT.ToString("yyyyMMdd")}.log");

            //string log = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} :: test";

            //if (!new DirectoryInfo(dirPath).Exists) { Directory.CreateDirectory(dirPath); }

            //if (!new FileInfo(fileName).Exists)
            //{
            //    using (StreamWriter sw = new StreamWriter(fileName))
            //    {
            //        sw.WriteLine(log);
            //        sw.Close();
            //    }
            //}
            //else
            //{
            //    using (StreamWriter sw = File.AppendText(fileName))
            //    {
            //        sw.WriteLine(log);
            //        sw.Close();
            //    }
            //}

        }

        private void btn_FolderFileList_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(_DIR_LOG);

            foreach (FileInfo file in di.GetFiles())
            {
                if (file.Extension.ToLower().CompareTo(".log") == 0)
                {
                    //tBox_Log.AppendText(file.FullName+"\n");

                    var Target = Convert.ToInt32(file.Name.Substring(0, file.Name.Length - 4));
                    var Compare = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));

                    if (Target < Compare)
                    {
                        tBox_Log.AppendText($"Target :: {Target} // Compare :: {Compare}" + "\n");
                    }

                    //tBox_Log.AppendText(file.Name + "\n");


                    tBox_Log.ScrollToCaret();
                }
            }
        }

        private void btn_OpenLogFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(_DIR_LOG);
        }

        private void btn_DeleteFile_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(_DIR_LOG);

            foreach (FileInfo file in di.GetFiles())
            {
                if (file.Extension.ToLower().CompareTo(".log") == 0)
                {
                    var Target = Convert.ToInt32(file.Name.Substring(0, file.Name.Length - 4));
                    var Compare = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));

                    if (Target < Compare)
                    {
                        File.Delete(file.FullName);
                        //tBox_Log.AppendText(file.FullName + "\n");
                        //tBox_Log.ScrollToCaret();
                    }
                }
            }
        }

        private void btn_LogTextClear_Click(object sender, EventArgs e)
        {
            tBox_Log.Clear();
        }

        private void btn_rangeCreate_Click(object sender, EventArgs e)
        {
            string sNowTime = DateTime.Now.ToString("yyyy-MM-dd");
            int nRange = Convert.ToInt32(tBox_Range.Text) * -1;

            DateTime sTime = DateTime.ParseExact(sNowTime, "yyyy-MM-dd", CultureInfo.InvariantCulture).AddDays(nRange);
            DateTime eTime = DateTime.ParseExact(sNowTime, "yyyy-MM-dd", CultureInfo.InvariantCulture);

            string dirPath = Environment.CurrentDirectory + _DIR_LOG;
            string log = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} :: test";

            for (var date = sTime; date <= eTime; date = date.AddDays(1))
            {
                string fileName = string.Format($"{dirPath}\\{date.ToString("yyyyMMdd")}.log");

                if (!new DirectoryInfo(dirPath).Exists) { Directory.CreateDirectory(dirPath); }

                if (!new FileInfo(fileName).Exists)
                {
                    using (StreamWriter sw = new StreamWriter(fileName))
                    {
                        sw.WriteLine(log);
                        sw.Close();
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(fileName))
                    {
                        sw.WriteLine(log);
                        sw.Close();
                    }
                }
            }
        }

        private void btn_RangeDeleteFile_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(_DIR_LOG);

            foreach (FileInfo file in di.GetFiles())
            {
                if (file.Extension.ToLower().CompareTo(".log") == 0)
                {
                    var Target = Convert.ToInt32(file.Name.Substring(0, file.Name.Length - 4));
                    var Compare = Convert.ToInt32(DateTime.Now.AddDays(Convert.ToInt32(tBox_DeleteRange.Text) * -1).ToString("yyyyMMdd"));

                    if (Target < Compare)
                    {
                        File.Delete(file.FullName);
                    }
                }
            }
        }
    }
}
