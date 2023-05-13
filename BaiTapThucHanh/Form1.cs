using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace BaiTapThucHanh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string scriptPath = @"D:\Project\CSharp\Winforms\BaiTapThucHanh\BaiTapThucHanh\data";
        private readonly string[] LangSelect = new string[] { "vi", "en", "de", "fr" };
        private int select1_Idx = 0;
        private int select2_Idx = 1;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.AddRange(new object[] { "Vietnamese", "English", "Germany", "France" });
            this.comboBox2.Items.AddRange(new object[] { "Vietnamese", "English", "Germany", "France" });
            this.comboBox1.SelectedIndex = this.select1_Idx;
            this.comboBox2.SelectedIndex = this.select2_Idx;
        }


        private void SysProcess(string workDir, string fileName, string scriptFile, string arg_val, TextBox outPut)
        {
            //MessageBox.Show(arg_val);
            ProcessStartInfo start = new ProcessStartInfo();
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            //start.RedirectStandardError = true;
            start.CreateNoWindow = true;
            start.WindowStyle = ProcessWindowStyle.Hidden;
            start.WorkingDirectory = workDir;
            start.Arguments = $"{scriptFile} \"{arg_val}\"";
            start.FileName = fileName;
            try
            {
                Process process = Process.Start(start);
                StreamReader st = process.StandardOutput;
                outPut.AppendText(st.ReadToEnd());
                process.WaitForExit();
                /*while(!process.StandardOutput.EndOfStream)
                {
                    outPut.AppendText(process.StandardOutput.ReadToEnd());
                    break;
                }*/
                process.Close();
            }
            catch (Exception ex)
            {
                outPut.AppendText(ex.Message);
                throw ex;
            }
        }

        private void btn_javaRun_Click(object sender, EventArgs e)
        {
            int a, b;
            bool a_ = int.TryParse(this.gt_1.Text, out a);
            bool b_ = int.TryParse(this.gt_2.Text, out b);
            string fileName = @"C:\Program Files\Java\jdk-20\bin\java.exe";
            string scriptFile = "script.java";

            if (a_ && b_)
            {
                string msg = $"{a}\" \"{b}";
                //MessageBox.Show(msg);
                SysProcess(scriptPath, fileName, scriptFile, msg, this.kq);
            }
            else
            {
                MessageBox.Show("Input không được để trống và chỉ chấp nhận số", "Caution");
            }

        }

        private void btn_PythonRun_Click(object sender, EventArgs e)
        {
            string msg = this.msg_textBox.Text;
            string fileName = @"C:\Users\vianh\AppData\Local\Programs\Python\Python311\python.exe";
            string scriptFile = "script.py";
            SysProcess(scriptPath, fileName, scriptFile, msg, this.kq);

        }

        /*private void btn_PlayMP3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(msg))
                {
                    string uri = msg
                    using(Mp3FileReader mp3 = new Mp3FileReader(msg))
                    {
                        using(WaveStream pcm = WaveFormatConversionStream.CreatePcmStream(mp3))
                        {
                            WaveFileWriter.CreateWaveFile(msg)
                        }
                    }
                    SoundPlayer player = new SoundPlayer($@"{scriptPath}\Sound\{msg}.mp3");
                    player.Play();
                }
                else
                {
                    MessageBox.Show($"Not found: {msg}.wav", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        */

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            select1_Idx = this.comboBox1.SelectedIndex;
            //MessageBox.Show($"text selected: {select1_Idx}");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            select2_Idx = this.comboBox2.SelectedIndex;
            //MessageBox.Show($"text selected: {select2_Idx}");

        }

        private void btn_Translate_Click(object sender, EventArgs e)
        {
            string content = this.textTranIn.Text;
            string langIn = LangSelect[select1_Idx];
            string langOut = LangSelect[select2_Idx];
            string argvIn = $"{langIn}\" \"{langOut}\" \"{content}";
            string fileName = @"C:\Users\vianh\AppData\Local\Programs\Python\Python311\python.exe";
            string scriptFile = "translateModule.py";
            this.textTranOut.Text = "";
            SysProcess(scriptPath, fileName, scriptFile, argvIn, this.textTranOut);
        }
    }
}
