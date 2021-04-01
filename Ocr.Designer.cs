
namespace 百度云识别
{
    partial class Baidu_Ocr
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Resulttext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxresult = new System.Windows.Forms.CheckBox();
            this.Apikey = new System.Windows.Forms.TextBox();
            this.SECkey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Resulttext
            // 
            this.Resulttext.Location = new System.Drawing.Point(444, 86);
            this.Resulttext.Multiline = true;
            this.Resulttext.Name = "Resulttext";
            this.Resulttext.ReadOnly = true;
            this.Resulttext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Resulttext.Size = new System.Drawing.Size(344, 382);
            this.Resulttext.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "选择图片文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 382);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // checkBoxresult
            // 
            this.checkBoxresult.AutoSize = true;
            this.checkBoxresult.Location = new System.Drawing.Point(697, 40);
            this.checkBoxresult.Name = "checkBoxresult";
            this.checkBoxresult.Size = new System.Drawing.Size(91, 24);
            this.checkBoxresult.TabIndex = 3;
            this.checkBoxresult.Text = "是否累计";
            this.checkBoxresult.UseVisualStyleBackColor = true;
            // 
            // Apikey
            // 
            this.Apikey.Location = new System.Drawing.Point(71, 26);
            this.Apikey.Name = "Apikey";
            this.Apikey.Size = new System.Drawing.Size(125, 27);
            this.Apikey.TabIndex = 4;
            // 
            // SECkey
            // 
            this.SECkey.Location = new System.Drawing.Point(328, 23);
            this.SECkey.Name = "SECkey";
            this.SECkey.Size = new System.Drawing.Size(125, 27);
            this.SECkey.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "APIkey";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "SECkey";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(472, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "选择文件夹";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(697, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 9;
            this.button3.Text = "清除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Baidu_Ocr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SECkey);
            this.Controls.Add(this.Apikey);
            this.Controls.Add(this.checkBoxresult);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Resulttext);
            this.Name = "Baidu_Ocr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "百度识别文本(by 吾爱:小白来袭2)";
            this.Load += new System.EventHandler(this.Baidu_Ocr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Resulttext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxresult;
        private System.Windows.Forms.TextBox Apikey;
        private System.Windows.Forms.TextBox SECkey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

