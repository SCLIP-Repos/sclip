namespace $safeprojectname$.SetupUserControls
{
    partial class InitialSetting
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
            this.OK_button = new System.Windows.Forms.Button();
            this.Psw_textBox = new System.Windows.Forms.TextBox();
            this.RePsw_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.View_label = new System.Windows.Forms.Label();
            this.Help_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OK_button
            // 
            this.OK_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK_button.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.OK_button.Location = new System.Drawing.Point(506, 241);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(98, 38);
            this.OK_button.TabIndex = 4;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // Psw_textBox
            // 
            this.Psw_textBox.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.Psw_textBox.Location = new System.Drawing.Point(215, 139);
            this.Psw_textBox.Name = "Psw_textBox";
            this.Psw_textBox.PasswordChar = '●';
            this.Psw_textBox.Size = new System.Drawing.Size(389, 25);
            this.Psw_textBox.TabIndex = 3;
            this.Psw_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RePsw_textBox
            // 
            this.RePsw_textBox.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.RePsw_textBox.Location = new System.Drawing.Point(215, 192);
            this.RePsw_textBox.Name = "RePsw_textBox";
            this.RePsw_textBox.PasswordChar = '●';
            this.RePsw_textBox.Size = new System.Drawing.Size(389, 25);
            this.RePsw_textBox.TabIndex = 5;
            this.RePsw_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13F);
            this.label1.Location = new System.Drawing.Point(114, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13F);
            this.label2.Location = new System.Drawing.Point(82, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Confirmation";
            // 
            // View_label
            // 
            this.View_label.AutoSize = true;
            this.View_label.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.View_label.Location = new System.Drawing.Point(610, 137);
            this.View_label.Name = "View_label";
            this.View_label.Size = new System.Drawing.Size(31, 28);
            this.View_label.TabIndex = 8;
            this.View_label.Text = "👁";
            // 
            // Help_label
            // 
            this.Help_label.AutoSize = true;
            this.Help_label.Font = new System.Drawing.Font("メイリオ", 10F);
            this.Help_label.Location = new System.Drawing.Point(678, 461);
            this.Help_label.Name = "Help_label";
            this.Help_label.Size = new System.Drawing.Size(24, 21);
            this.Help_label.TabIndex = 9;
            this.Help_label.Text = "？";
            // 
            // InitialSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Help_label);
            this.Controls.Add(this.View_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RePsw_textBox);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.Psw_textBox);
            this.Name = "InitialSetting";
            this.Size = new System.Drawing.Size(705, 482);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.TextBox Psw_textBox;
        private System.Windows.Forms.TextBox RePsw_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label View_label;
        private System.Windows.Forms.Label Help_label;
    }
}
