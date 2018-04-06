namespace $safeprojectname$.View.Setup
{
    partial class Agree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agree));
            this.License_richTextBox = new System.Windows.Forms.RichTextBox();
            this.Next_button = new System.Windows.Forms.Button();
            this.Agree_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // License_richTextBox
            // 
            this.License_richTextBox.BackColor = System.Drawing.Color.White;
            this.License_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.License_richTextBox.Location = new System.Drawing.Point(0, 30);
            this.License_richTextBox.Name = "License_richTextBox";
            this.License_richTextBox.ReadOnly = true;
            this.License_richTextBox.Size = new System.Drawing.Size(619, 355);
            this.License_richTextBox.TabIndex = 0;
            this.License_richTextBox.Text = resources.GetString("License_richTextBox.Text");
            // 
            // Next_button
            // 
            this.Next_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next_button.Location = new System.Drawing.Point(625, 350);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(95, 35);
            this.Next_button.TabIndex = 1;
            this.Next_button.Text = "NEXT";
            this.Next_button.UseVisualStyleBackColor = true;
            this.Next_button.Click += new System.EventHandler(this.Next_button_Click);
            // 
            // Agree_checkBox
            // 
            this.Agree_checkBox.AutoSize = true;
            this.Agree_checkBox.Location = new System.Drawing.Point(643, 287);
            this.Agree_checkBox.Name = "Agree_checkBox";
            this.Agree_checkBox.Size = new System.Drawing.Size(62, 16);
            this.Agree_checkBox.TabIndex = 2;
            this.Agree_checkBox.Text = "AGREE";
            this.Agree_checkBox.UseVisualStyleBackColor = true;
            // 
            // Agree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Agree_checkBox);
            this.Controls.Add(this.Next_button);
            this.Controls.Add(this.License_richTextBox);
            this.Name = "Agree";
            this.Size = new System.Drawing.Size(720, 385);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox License_richTextBox;
        private System.Windows.Forms.Button Next_button;
        private System.Windows.Forms.CheckBox Agree_checkBox;
    }
}
