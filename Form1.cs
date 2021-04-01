using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 百度云识别
{
    public partial class Form1 : Form
    {
        Baidu_Ocr baidu_Ocr=new Baidu_Ocr();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            baidu_Ocr.ShowDialog();
           
        }
    }
}
