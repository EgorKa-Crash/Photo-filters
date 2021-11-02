namespace CGLaba4
{
    partial class PhotoFilters
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFile = new System.Windows.Forms.Button();
            this.grayFilter = new System.Windows.Forms.Button();
            this.linecontrastFilter = new System.Windows.Forms.Button();
            this.linecontrastVal = new System.Windows.Forms.TextBox();
            this.blurFilter = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(186, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 323);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(13, 28);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(118, 23);
            this.openFile.TabIndex = 1;
            this.openFile.Text = "Open photo";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.OpenFileClick);
            // 
            // grayFilter
            // 
            this.grayFilter.Location = new System.Drawing.Point(13, 58);
            this.grayFilter.Name = "grayFilter";
            this.grayFilter.Size = new System.Drawing.Size(118, 23);
            this.grayFilter.TabIndex = 5;
            this.grayFilter.Text = "Black & white";
            this.grayFilter.UseVisualStyleBackColor = true;
            this.grayFilter.Click += new System.EventHandler(this.GrayFilterClick);
            // 
            // linecontrastFilter
            // 
            this.linecontrastFilter.Location = new System.Drawing.Point(13, 88);
            this.linecontrastFilter.Name = "linecontrastFilter";
            this.linecontrastFilter.Size = new System.Drawing.Size(116, 23);
            this.linecontrastFilter.TabIndex = 6;
            this.linecontrastFilter.Text = "Threshold processing";
            this.linecontrastFilter.UseVisualStyleBackColor = true;
            this.linecontrastFilter.Click += new System.EventHandler(this.LinecontrastFilterClick);
            // 
            // linecontrastVal
            // 
            this.linecontrastVal.Location = new System.Drawing.Point(135, 91);
            this.linecontrastVal.MaxLength = 3;
            this.linecontrastVal.Name = "linecontrastVal";
            this.linecontrastVal.Size = new System.Drawing.Size(45, 20);
            this.linecontrastVal.TabIndex = 11;
            this.linecontrastVal.Text = "100";
            // 
            // blurFilter
            // 
            this.blurFilter.Location = new System.Drawing.Point(13, 118);
            this.blurFilter.Name = "blurFilter";
            this.blurFilter.Size = new System.Drawing.Size(116, 23);
            this.blurFilter.TabIndex = 12;
            this.blurFilter.Text = "Blur";
            this.blurFilter.UseVisualStyleBackColor = true;
            this.blurFilter.Click += new System.EventHandler(this.BlurFilterClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(676, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(484, 323);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(186, 341);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(484, 323);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(676, 341);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(484, 323);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // PhotoFilters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 665);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.blurFilter);
            this.Controls.Add(this.linecontrastVal);
            this.Controls.Add(this.linecontrastFilter);
            this.Controls.Add(this.grayFilter);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PhotoFilters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo filters";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button grayFilter;
        private System.Windows.Forms.Button linecontrastFilter;
        private System.Windows.Forms.TextBox linecontrastVal;
        private System.Windows.Forms.Button blurFilter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

