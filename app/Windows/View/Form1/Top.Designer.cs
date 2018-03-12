namespace $safeprojectname$.View.Form1
{
    partial class Top
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Top));
            this.Lock_pictureBox = new System.Windows.Forms.PictureBox();
            this.Sets_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Lock_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Lock_pictureBox
            // 
            this.Lock_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Lock_pictureBox.Image")));
            this.Lock_pictureBox.Location = new System.Drawing.Point(124, 82);
            this.Lock_pictureBox.Name = "Lock_pictureBox";
            this.Lock_pictureBox.Size = new System.Drawing.Size(470, 454);
            this.Lock_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Lock_pictureBox.TabIndex = 0;
            this.Lock_pictureBox.TabStop = false;
            this.Lock_pictureBox.Click += new System.EventHandler(this.Lock_pictureBox_Click);
            // 
            // Sets_label
            // 
            this.Sets_label.AutoSize = true;
            this.Sets_label.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sets_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Sets_label.Location = new System.Drawing.Point(692, 617);
            this.Sets_label.Name = "Sets_label";
            this.Sets_label.Size = new System.Drawing.Size(34, 32);
            this.Sets_label.TabIndex = 1;
            this.Sets_label.Text = "⚙";
            this.Sets_label.Click += new System.EventHandler(this.Sets_label_Click);
            // 
            // Top
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Sets_label);
            this.Controls.Add(this.Lock_pictureBox);
            this.Name = "Top";
            this.Size = new System.Drawing.Size(726, 649);
            ((System.ComponentModel.ISupportInitialize)(this.Lock_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Lock_pictureBox;
        private System.Windows.Forms.Label Sets_label;
    }
}
