namespace $safeprojectname$.SetupUserControls
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Agree_checkBox = new System.Windows.Forms.CheckBox();
            this.Next1_button = new System.Windows.Forms.Button();
            
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Verdana", 10F);
            this.richTextBox1.Location = new System.Drawing.Point(3, 45);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(570, 437);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Agree_checkBox
            // 
            this.Agree_checkBox.AutoSize = true;
            this.Agree_checkBox.Font = new System.Drawing.Font("Verdana", 10F);
            this.Agree_checkBox.Location = new System.Drawing.Point(608, 342);
            this.Agree_checkBox.Name = "Agree_checkBox";
            this.Agree_checkBox.Size = new System.Drawing.Size(68, 21);
            this.Agree_checkBox.TabIndex = 1;
            this.Agree_checkBox.Text = "Agree";
            this.Agree_checkBox.UseVisualStyleBackColor = true;
            // 
            // Next1_button
            // 
            this.Next1_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next1_button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next1_button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Next1_button.Location = new System.Drawing.Point(579, 433);
            this.Next1_button.Name = "Next1_button";
            this.Next1_button.Size = new System.Drawing.Size(123, 46);
            this.Next1_button.TabIndex = 2;
            this.Next1_button.Text = "NEXT";
            this.Next1_button.UseVisualStyleBackColor = true;
            this.Next1_button.Click += new System.EventHandler(this.Next1_button_Click);

            // 
            // Agree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Next1_button);
            this.Controls.Add(this.Agree_checkBox);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Agree";
            this.Size = new System.Drawing.Size(705, 482);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox Agree_checkBox;
        private System.Windows.Forms.Button Next1_button;
    }
}
