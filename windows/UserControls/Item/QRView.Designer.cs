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
            System.Windows.Forms.WebBrowser QR_webBrowser;
            this.Close_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            QR_webBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // Close_button
            // 
            this.Close_button.BackColor = System.Drawing.Color.White;
            this.Close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_button.Location = new System.Drawing.Point(654, 481);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(75, 23);
            this.Close_button.TabIndex = 14;
            this.Close_button.Text = "閉じる";
            this.Close_button.UseVisualStyleBackColor = false;
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.Color.White;
            this.Back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_button.Location = new System.Drawing.Point(573, 481);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(75, 23);
            this.Back_button.TabIndex = 15;
            this.Back_button.Text = "戻る";
            this.Back_button.UseVisualStyleBackColor = false;
            // 
            // QR_webBrowser
            // 
            QR_webBrowser.AllowWebBrowserDrop = false;
            QR_webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            QR_webBrowser.CausesValidation = false;
            QR_webBrowser.IsWebBrowserContextMenuEnabled = false;
            QR_webBrowser.Location = new System.Drawing.Point(168, 59);
            QR_webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            QR_webBrowser.Name = "QR_webBrowser";
            QR_webBrowser.ScrollBarsEnabled = false;
            QR_webBrowser.Size = new System.Drawing.Size(390, 342);
            QR_webBrowser.TabIndex = 16;
            QR_webBrowser.TabStop = false;
            QR_webBrowser.Url = new System.Uri("https://chart.googleapis.com/chart?cht=qr&chl=https://facebook.com&chs=300x300&ch" +
        "ld=H|1", System.UriKind.Absolute);
            // 
            // QRView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(QR_webBrowser);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Close_button);
            this.Name = "QRView";
            this.Size = new System.Drawing.Size(732, 507);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Button Back_button;
    }
}
