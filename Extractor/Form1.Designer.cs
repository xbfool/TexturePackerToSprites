namespace Extractor
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.XMLFile = new System.Windows.Forms.Button();
            this.RGBFile = new System.Windows.Forms.Button();
            this.AlphaFile = new System.Windows.Forms.Button();
            this.ToSprites = new System.Windows.Forms.Button();
            this.XMLPath = new System.Windows.Forms.Label();
            this.RGBPath = new System.Windows.Forms.Label();
            this.AlphaPath = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // XMLFile
            // 
            this.XMLFile.Location = new System.Drawing.Point(64, 39);
            this.XMLFile.Name = "XMLFile";
            this.XMLFile.Size = new System.Drawing.Size(111, 48);
            this.XMLFile.TabIndex = 0;
            this.XMLFile.Text = "XMLFile";
            this.XMLFile.UseVisualStyleBackColor = true;
            this.XMLFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // RGBFile
            // 
            this.RGBFile.Location = new System.Drawing.Point(64, 108);
            this.RGBFile.Name = "RGBFile";
            this.RGBFile.Size = new System.Drawing.Size(111, 43);
            this.RGBFile.TabIndex = 1;
            this.RGBFile.Text = "RGBFile";
            this.RGBFile.UseVisualStyleBackColor = true;
            this.RGBFile.Click += new System.EventHandler(this.RGBFile_Click);
            // 
            // AlphaFile
            // 
            this.AlphaFile.Location = new System.Drawing.Point(64, 180);
            this.AlphaFile.Name = "AlphaFile";
            this.AlphaFile.Size = new System.Drawing.Size(111, 44);
            this.AlphaFile.TabIndex = 2;
            this.AlphaFile.Text = "AlphaFile";
            this.AlphaFile.UseVisualStyleBackColor = true;
            this.AlphaFile.Click += new System.EventHandler(this.AlphaFile_Click);
            // 
            // ToSprites
            // 
            this.ToSprites.Location = new System.Drawing.Point(64, 270);
            this.ToSprites.Name = "ToSprites";
            this.ToSprites.Size = new System.Drawing.Size(111, 43);
            this.ToSprites.TabIndex = 3;
            this.ToSprites.Text = "ToSprites";
            this.ToSprites.UseVisualStyleBackColor = true;
            // 
            // XMLPath
            // 
            this.XMLPath.AutoSize = true;
            this.XMLPath.Location = new System.Drawing.Point(215, 56);
            this.XMLPath.Name = "XMLPath";
            this.XMLPath.Size = new System.Drawing.Size(0, 15);
            this.XMLPath.TabIndex = 4;
            // 
            // RGBPath
            // 
            this.RGBPath.AutoSize = true;
            this.RGBPath.Location = new System.Drawing.Point(215, 122);
            this.RGBPath.Name = "RGBPath";
            this.RGBPath.Size = new System.Drawing.Size(0, 15);
            this.RGBPath.TabIndex = 5;
            // 
            // AlphaPath
            // 
            this.AlphaPath.AutoSize = true;
            this.AlphaPath.Location = new System.Drawing.Point(218, 194);
            this.AlphaPath.Name = "AlphaPath";
            this.AlphaPath.Size = new System.Drawing.Size(0, 15);
            this.AlphaPath.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AlphaPath);
            this.Controls.Add(this.RGBPath);
            this.Controls.Add(this.XMLPath);
            this.Controls.Add(this.ToSprites);
            this.Controls.Add(this.AlphaFile);
            this.Controls.Add(this.RGBFile);
            this.Controls.Add(this.XMLFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button XMLFile;
        private System.Windows.Forms.Button RGBFile;
        private System.Windows.Forms.Button AlphaFile;
        private System.Windows.Forms.Button ToSprites;
        private System.Windows.Forms.Label XMLPath;
        private System.Windows.Forms.Label RGBPath;
        private System.Windows.Forms.Label AlphaPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

