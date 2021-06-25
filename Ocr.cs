
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
        private void btn_Image_Click(object sender, EventArgs e)
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

                ThreadPool.QueueUserWorkItem(new WaitCallback(Ocr), new BaiduOcrClass(true,imagestream) );
            }
        }
        /// <summary>
        /// OCR识别开始方法
        /// </summary>
        /// <param name="s"></param>
        protected void Ocr(object s)
        {
            BaiduOcrClass baiduOcrClass = (BaiduOcrClass)s;
            var stream = baiduOcrClass.imageStream;
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
            SaveFileText((FileStream)stream, resustring,baiduOcrClass.isAuto);
        }
        /// <summary>
        /// 保存识别文本
        /// </summary>
        /// <param name="fileStream"></param>
        /// <param name="resustring"></param>
        protected void SaveFileText(FileStream fileStream, string resustring ,Boolean IsAuto)
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
                    if (IsAuto)
                    {
                        filepath += "OCR翻译完成文本";
                    }
                    else
                    {
                        filepath += "\\" + spiltstr[i];
                    }
                    
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
        /// <summary>
        /// 窗口加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Baidu_Ocr_Load(object sender, EventArgs e)
        {
            ThreadPool.SetMaxThreads(2,int.MaxValue);
            //关闭线程安全
            Control.CheckForIllegalCrossThreadCalls = false;
            
            // 注册热键为Alt+Ctrl+C, "100"为唯一标识热键

            HotKey.RegisterHotKey(Handle, 100, HotKey.KeyModifiers.None, Keys.F2);
        }
        /// <summary>
        /// 窗口关闭时卸载热键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Baidu_Ocr_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 卸载热键
            HotKey.UnregisterHotKey(Handle, 100);
        }
        /// <summary>
        /// 重写WndProc()方法，通过监视系统消息，来调用过程
        /// 监视Windows消息
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            //如果m.Msg的值为0x0312那么表示用户按下了热键
            const int WM_HOTKEY = 0x0312;
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    if (m.WParam.ToString() == "100")
                    {
                        CatchAsync();
                    }

                    break;
            }

            // 将系统消息传递自父类的WndProc
            base.WndProc(ref m);
        }
        private void Btn_ImageList_Click(object sender, EventArgs e)
        {
            List<Stream> list = new List<Stream>();
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                director(fbd.SelectedPath,ref list);
                if (list!=null)
                {
                    //拆分成两个列表，走两个线程
                    //增加速度
                    //注意:由于QPS限制 最大为2
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
            //不使用异步 防止QPS超过2
            foreach (var imagestream in listStream)
            {
                Ocr(new BaiduOcrClass(true, imagestream));
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

        private void Btn_clean_Click(object sender, EventArgs e)
        {
            Resulttext.Clear();
        }

        #region 快捷键截图
       
        /// <summary>
        /// 快捷键截屏
        /// </summary>
        private async void CatchAsync()
        {
            this.Hide();
            Cutter cutter = new Cutter();
            bool CnaRef = false;
            cutter.Show();
            await Task.Run(() => {
                try
                {
                    while (!CnaRef)
                    {
                        if (cutter.CanRead)
                        {
                            CnaRef = true;
                            Action action = () => { pictureBox1.Image = (Bitmap)Clipboard.GetImage().Clone(); };
                            this.pictureBox1.BeginInvoke(action);
                            //Clipboard.Clear();
                            cutter.Dispose();
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            });
            this.Show();
            but_Ocr.Enabled = true;
        }
        private void but_Ocr_Click(object sender, EventArgs e)
        {
            BtnOcr();
        }
        /// <summary>
        /// 点击识别
        /// </summary>
        private async void BtnOcr()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                var imagePath = fbd.SelectedPath + $"\\{Guid.NewGuid()}.jpg";
                pictureBox1.Image.Save(imagePath);
                File.SetAttributes(imagePath, FileAttributes.Hidden);
                var stream = File.OpenRead(imagePath);
                await Task.Run(() => Ocr(new BaiduOcrClass(false, stream)));

                File.Delete(imagePath);
                but_Ocr.Enabled = false;
                //MessageBox.Show(fbd.SelectedPath);
            }
        }
        #endregion


    }
}
