
namespace 百度云识别
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Baidu_ocr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Baidu_ocr
            // 
            this.Baidu_ocr.Location = new System.Drawing.Point(12, 12);
            this.Baidu_ocr.Name = "Baidu_ocr";
            this.Baidu_ocr.Size = new System.Drawing.Size(187, 29);
            this.Baidu_ocr.TabIndex = 0;
            this.Baidu_ocr.Text = "基于百度的OCR文字识别";
            this.Baidu_ocr.UseVisualStyleBackColor = true;
            this.Baidu_ocr.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Baidu_ocr);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.Button Baidu_ocr;
    }
}