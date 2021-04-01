using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 百度云识别
{
    public partial class Baidu_Ocr : Form
    {
        public Baidu_Ocr()
        {
            InitializeComponent();
        }
        public static BaiduOcR BaiduOcR { get; set; }
        public static OpenFileDialog fileDialog;
        //默认打开路径
        public string FilePath;
        public string Title;
        public string Filter = "图片(*.jpg,*.jpge,*.bmp,*.png)|*.jpg;*.jpge;*.bmp;*.png";
        private void button1_Click(object sender, EventArgs e)
        {
            fileDialog = new OpenFileDialog();
            //fileDialog.Filter = Filter;//过滤选项设置，文本文件，所有文件。
            fileDialog.FilterIndex = 0;//当前使用第二个过滤字符串
            fileDialog.RestoreDirectory = true;//对话框关闭时恢复原目录
            fileDialog.Title = Title;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                
                Stream imagestream = fileDialog.OpenFile();
                pictureBox1.Image = new Bitmap(imagestream);
                ThreadPool.QueueUserWorkItem(new WaitCallback(Ocrclick), imagestream);
            }
        }
        protected void Ocrclick(object s)
        {
            Stream stream = (Stream)s;
            if (this.Apikey.Text.Length > 0)
            {
                BaiduOcR = new BaiduOcR(this.Apikey.Text, this.SECkey.Text);
            }
            else
            {
                BaiduOcR = new BaiduOcR();
            }
            string resustring = "";
            if (checkBoxresult.Checked)
            {
                resustring="\r\n" + BaiduOcR.Ocr(stream);
                Resulttext.Text += resustring;
            }
            else
            {
                resustring = BaiduOcR.Ocr((stream));
                Resulttext.Text = resustring;
            }
            SaveFileText((FileStream)stream, resustring);
        }
        /// <summary>
        /// 保存识别文本
        /// </summary>
        /// <param name="fileStream"></param>
        /// <param name="resustring"></param>
        protected void SaveFileText(FileStream fileStream, string resustring )
        {
            string filepath = fileStream.Name;
            var spiltstr = filepath.Split("\\");
            filepath = "";
            for (int i = 0; i < spiltstr.Length; i++)
            {
                if (i == spiltstr.Length - 1)
                {
                    filepath +="\\" + spiltstr[i]+".txt";
                }
                else if (i == spiltstr.Length - 2)
                {
                    filepath += "OCR翻译完成文本";
                    if (!Directory.Exists(filepath))
                        Directory.CreateDirectory(filepath);
                }
                else
                {
                    filepath +=   spiltstr[i]+ "\\";
                }
                
            }
            StreamWriter streamWriter = new StreamWriter(filepath,false);
            streamWriter.Write(resustring);
            streamWriter.Close();
            fileStream.Close();
        }
        private void Baidu_Ocr_Load(object sender, EventArgs e)
        {
            ThreadPool.SetMaxThreads(2,int.MaxValue);
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Stream> list = new List<Stream>();
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                director(fbd.SelectedPath,ref list);
                if (list!=null)
                {
                    List<Stream> liststreamOne = new List<Stream>();
                    List<Stream> liststreamTwo = new List<Stream>();
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (i%2==0)
                        {
                            liststreamTwo.Add(list[i]);
                        }
                        else
                        {
                            liststreamOne.Add(list[i]);
                        }
                    }
                    ThreadPool.QueueUserWorkItem(new WaitCallback(OcrList), liststreamOne);
                    ThreadPool.QueueUserWorkItem(new WaitCallback(OcrList), liststreamTwo);
                }
            } 
            
        }
        private void OcrList(object s)
        {
            List<Stream> listStream = (List<Stream>)s;
            foreach (var item in listStream)
            {
                Ocrclick(item);
            }
        }
        /// <summary>
        /// 获取文件夹内的文件
        /// </summary>
        /// <param name="dirs"></param>
        /// <param name="list"></param>
        public void director(string dirs,ref List<Stream> list)
        {
            
            //绑定到指定的文件夹目录
            DirectoryInfo dir = new DirectoryInfo(dirs);
            //检索表示当前目录的文件和子目录
            FileSystemInfo[] fsinfos = dir.GetFileSystemInfos();
            //遍历检索的文件和子目录
            foreach (FileSystemInfo fsinfo in fsinfos)
            {
                //判断是否为空文件夹　　
                if (fsinfo is DirectoryInfo)
                {
                    //递归调用
                    director(fsinfo.FullName,ref list);
                }
                else
                {
                    Console.WriteLine(fsinfo.FullName);
                    Stream stream = ((FileInfo)fsinfo).Open(FileMode.Open);
                    //将得到的文件全路径放入到集合中
                    list.Add(stream);
                    
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Resulttext.Clear();
        }
    }
}
