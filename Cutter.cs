using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 百度云识别
{
    public class Cutter : Form
    {
        public Boolean Is_CatchStart;
        public Boolean CanRead;
        private Point DownPonint { get; set; }
        private Bitmap WinBmp { get; set; }
        public Bitmap retBitmap { get; set; }
        private Rectangle CatchRectangle;
        public Cutter()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Width = Screen.AllScreens[0].Bounds.Width;
            this.Height=Screen.AllScreens[0].Bounds.Height;
            this.MouseDown += Cutter_MouseDown;
            this.MouseClick += Cutter_MouseClick;
            this.MouseMove += Cutter_MouseMove;
            this.MouseUp += Cutter_MouseUp;
            WinBmp = new Bitmap(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height);
            Graphics graphics = Graphics.FromImage(WinBmp);
            graphics.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height));
            graphics.Dispose();
            this.BackgroundImage = WinBmp;
        }
        /// <summary>
        /// 鼠标抬起，结束截图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cutter_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                if (Is_CatchStart)
                {
                    Is_CatchStart = false;

                    Bitmap CatchedBmp = new Bitmap(CatchRectangle.Width, CatchRectangle.Height);
                    Graphics g = Graphics.FromImage(CatchedBmp);
                  
                    // 把originBmp中指定部分按照指定大小画到空白图片上
                    // CatchRectangle指定originBmp中指定部分
                    // 第二个参数指定绘制到空白图片的位置和大小
                    // 画完后CatchedBmp不再是空白图片了，而是具有与截取的图片一样的内容
                    g.DrawImage(WinBmp, new Rectangle(0, 0, CatchRectangle.Width, CatchRectangle.Height), CatchRectangle, GraphicsUnit.Pixel);
                    // 将图片保存到剪切板中
                    Clipboard.Clear();
                    Clipboard.SetImage(CatchedBmp);
                    g.Dispose();
                    retBitmap = CatchedBmp;
                    WinBmp.Dispose();
                    CatchedBmp.Dispose();
                    this.CanRead = true;
                    this.Close();
                }
            }
        } 

        /// <summary>
        /// 鼠标点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cutter_MouseDown(object sender, MouseEventArgs e)
        {
            
            // 鼠标左键按下是开始画图，也就是截图
            if (e.Button == MouseButtons.Left)
            {
                if (!Is_CatchStart)
                {
                    Is_CatchStart = true;
                    // 保存此时鼠标按下坐标
                    DownPonint = new Point(e.X, e.Y);
                }
            }

                
        }
        /// <summary>
        /// 鼠标右键点击结束截图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cutter_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        /// <summary>
        /// 按下左键后移动鼠标，标记截图区域
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cutter_MouseMove(object sender, MouseEventArgs e)
        {
            // 确保截图开始
            if (Is_CatchStart)
            {
                // 新建一个图片对象，让它与屏幕图片相同
                Bitmap copyBmp = (Bitmap)WinBmp.Clone();

                // 获取鼠标按下的坐标
                Point newPoint = new Point(DownPonint.X, DownPonint.Y);

                // 新建画板和画笔
                Graphics g = Graphics.FromImage(copyBmp);
                Pen p = new Pen(Color.Red, 1);

                // 获取矩形的长宽
                int width = Math.Abs(e.X - DownPonint.X);
                int height = Math.Abs(e.Y - DownPonint.Y);
                if (e.X < DownPonint.X)
                {
                    newPoint.X = e.X;
                }
                if (e.Y < DownPonint.Y)
                {
                    newPoint.Y = e.Y;
                }

                CatchRectangle = new Rectangle(newPoint, new Size(width, height));
                
                // 将矩形画在画板上
                g.DrawRectangle(p, CatchRectangle);

                // 释放目前的画板
                g.Dispose();
                p.Dispose();
                // 从当前窗体创建新的画板
                Graphics g1 = this.CreateGraphics();

                // 将刚才所画的图片画到截图窗体上
                // 为什么不直接在当前窗体画图呢？
                // 如果自己解决将矩形画在窗体上，会造成图片抖动并且有无数个矩形
                // 这样实现也属于二次缓冲技术
                g1.DrawImage(copyBmp, new Point(0, 0));
                g1.Dispose();
              
                // 释放拷贝图片，防止内存被大量消耗
                copyBmp.Dispose();
            }
        }
    }
}
