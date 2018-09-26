namespace SCLIP.UserControls.Item
{
    partial class QRView
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Close_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(203, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Close_button
            // 
            this.Close_button.Location = new System.Drawing.Point(654, 481);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(75, 23);
            this.Close_button.TabIndex = 14;
            this.Close_button.Text = "閉じる";
            this.Close_button.UseVisualStyleBackColor = true;
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(573, 481);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(75, 23);
            this.Back_button.TabIndex = 15;
            this.Back_button.Text = "戻る";
            this.Back_button.UseVisualStyleBackColor = true;
            // 
            // QRView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "QRView";
            this.Size = new System.Drawing.Size(732, 507);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Button Back_button;
    }
}
