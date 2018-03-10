namespace $safeprojectname$.Form1UserControls
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
            this.Settings_label = new System.Windows.Forms.Label();
            this.Help_label = new System.Windows.Forms.Label();
            this.Lock_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Lock_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Settings_label
            // 
            this.Settings_label.AutoSize = true;
            this.Settings_label.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_label.Location = new System.Drawing.Point(705, 606);
            this.Settings_label.Name = "Settings_label";
            this.Settings_label.Size = new System.Drawing.Size(35, 32);
            this.Settings_label.TabIndex = 0;
            this.Settings_label.Text = "⚙";
            this.Settings_label.Click += new System.EventHandler(this.Settings_label_Click);
            // 
            // Help_label
            // 
            this.Help_label.AutoSize = true;
            this.Help_label.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.Help_label.Location = new System.Drawing.Point(687, 614);
            this.Help_label.Name = "Help_label";
            this.Help_label.Size = new System.Drawing.Size(15, 19);
            this.Help_label.TabIndex = 1;
            this.Help_label.Text = "?";
            // 
            // Lock_pictureBox
            // 
            this.Lock_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Lock_pictureBox.Image")));
            this.Lock_pictureBox.Location = new System.Drawing.Point(321, 158);
            this.Lock_pictureBox.Name = "Lock_pictureBox";
            this.Lock_pictureBox.Size = new System.Drawing.Size(240, 223);
            this.Lock_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Lock_pictureBox.TabIndex = 6;
            this.Lock_pictureBox.TabStop = false;
            this.Lock_pictureBox.Click += new System.EventHandler(this.Lock_pictureBox_Click);
            // 
            // Top
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Lock_pictureBox);
            this.Controls.Add(this.Help_label);
            this.Controls.Add(this.Settings_label);
            this.Name = "Top";
            this.Size = new System.Drawing.Size(743, 641);
            ((System.ComponentModel.ISupportInitialize)(this.Lock_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Settings_label;
        private System.Windows.Forms.Label Help_label;
        private System.Windows.Forms.PictureBox Lock_pictureBox;
    }
}
