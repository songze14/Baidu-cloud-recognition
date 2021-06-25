
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
            this.btn_Image = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxresult = new System.Windows.Forms.CheckBox();
            this.Apikey = new System.Windows.Forms.TextBox();
            this.SECkey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ImageList = new System.Windows.Forms.Button();
            this.btn_clean = new System.Windows.Forms.Button();
            this.but_Ocr = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkB_SaveTextFile = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Resulttext
            // 
            this.Resulttext.Location = new System.Drawing.Point(343, 87);
            this.Resulttext.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Resulttext.Multiline = true;
            this.Resulttext.Name = "Resulttext";
            this.Resulttext.ReadOnly = true;
            this.Resulttext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Resulttext.Size = new System.Drawing.Size(268, 421);
            this.Resulttext.TabIndex = 0;
            // 
            // btn_Image
            // 
            this.btn_Image.Location = new System.Drawing.Point(421, 40);
            this.btn_Image.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Image.Name = "btn_Image";
            this.btn_Image.Size = new System.Drawing.Size(93, 25);
            this.btn_Image.TabIndex = 1;
            this.btn_Image.Text = "选择图片文件";
            this.btn_Image.UseVisualStyleBackColor = true;
            this.btn_Image.Click += new System.EventHandler(this.btn_Image_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(9, 87);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 421);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // checkBoxresult
            // 
            this.checkBoxresult.AutoSize = true;
            this.checkBoxresult.Location = new System.Drawing.Point(518, 43);
            this.checkBoxresult.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBoxresult.Name = "checkBoxresult";
            this.checkBoxresult.Size = new System.Drawing.Size(75, 21);
            this.checkBoxresult.TabIndex = 3;
            this.checkBoxresult.Text = "是否累计";
            this.checkBoxresult.UseVisualStyleBackColor = true;
            // 
            // Apikey
            // 
            this.Apikey.Location = new System.Drawing.Point(60, 22);
            this.Apikey.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Apikey.Name = "Apikey";
            this.Apikey.Size = new System.Drawing.Size(98, 23);
            this.Apikey.TabIndex = 4;
            // 
            // SECkey
            // 
            this.SECkey.Location = new System.Drawing.Point(60, 58);
            this.SECkey.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SECkey.Name = "SECkey";
            this.SECkey.Size = new System.Drawing.Size(98, 23);
            this.SECkey.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "APIkey";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "SECkey";
            // 
            // btn_ImageList
            // 
            this.btn_ImageList.Location = new System.Drawing.Point(421, 12);
            this.btn_ImageList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_ImageList.Name = "btn_ImageList";
            this.btn_ImageList.Size = new System.Drawing.Size(73, 25);
            this.btn_ImageList.TabIndex = 8;
            this.btn_ImageList.Text = "选择文件夹";
            this.btn_ImageList.UseVisualStyleBackColor = true;
            this.btn_ImageList.Click += new System.EventHandler(this.Btn_ImageList_Click);
            // 
            // btn_clean
            // 
            this.btn_clean.Location = new System.Drawing.Point(518, 12);
            this.btn_clean.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(73, 25);
            this.btn_clean.TabIndex = 9;
            this.btn_clean.Text = "清除";
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.Btn_clean_Click);
            // 
            // but_Ocr
            // 
            this.but_Ocr.Enabled = false;
            this.but_Ocr.Location = new System.Drawing.Point(78, 19);
            this.but_Ocr.Name = "but_Ocr";
            this.but_Ocr.Size = new System.Drawing.Size(75, 23);
            this.but_Ocr.TabIndex = 10;
            this.but_Ocr.Text = "点击识别";
            this.but_Ocr.UseVisualStyleBackColor = true;
            this.but_Ocr.Click += new System.EventHandler(this.but_Ocr_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "F2截图";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkB_SaveTextFile);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.but_Ocr);
            this.groupBox1.Location = new System.Drawing.Point(163, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 44);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "快捷键截屏";
            // 
            // checkB_SaveTextFile
            // 
            this.checkB_SaveTextFile.AutoSize = true;
            this.checkB_SaveTextFile.Location = new System.Drawing.Point(159, 18);
            this.checkB_SaveTextFile.Name = "checkB_SaveTextFile";
            this.checkB_SaveTextFile.Size = new System.Drawing.Size(87, 21);
            this.checkB_SaveTextFile.TabIndex = 12;
            this.checkB_SaveTextFile.Text = "保存为文件";
            this.checkB_SaveTextFile.UseVisualStyleBackColor = true;
            // 
            // Baidu_Ocr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 520);
            this.Controls.Add(this.btn_clean);
            this.Controls.Add(this.btn_ImageList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SECkey);
            this.Controls.Add(this.Apikey);
            this.Controls.Add(this.checkBoxresult);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Image);
            this.Controls.Add(this.Resulttext);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Baidu_Ocr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "百度识别文本(by 吾爱:小白来袭2)";
            this.Load += new System.EventHandler(this.Baidu_Ocr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private System.Windows.Forms.TextBox Resulttext;
        private System.Windows.Forms.Button btn_Image;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxresult;
        private System.Windows.Forms.TextBox Apikey;
        private System.Windows.Forms.TextBox SECkey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ImageList;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.Button but_Ocr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkB_SaveTextFile;
    }
}

