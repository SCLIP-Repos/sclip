namespace SCLIP.UserControls.Setup
{
    partial class Psw
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
            this.NewPsw_textBox = new System.Windows.Forms.TextBox();
            this.ReNewPsw_textBox = new System.Windows.Forms.TextBox();
            this.PswBack_button = new System.Windows.Forms.Button();
            this.PswNext_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Backupcode_textBox = new System.Windows.Forms.TextBox();
            this.CreateBackupcode_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewPsw_textBox
            // 
            this.NewPsw_textBox.Location = new System.Drawing.Point(109, 42);
            this.NewPsw_textBox.Name = "NewPsw_textBox";
            this.NewPsw_textBox.PasswordChar = '●';
            this.NewPsw_textBox.Size = new System.Drawing.Size(299, 19);
            this.NewPsw_textBox.TabIndex = 0;
            // 
            // ReNewPsw_textBox
            // 
            this.ReNewPsw_textBox.Location = new System.Drawing.Point(109, 87);
            this.ReNewPsw_textBox.Name = "ReNewPsw_textBox";
            this.ReNewPsw_textBox.PasswordChar = '●';
            this.ReNewPsw_textBox.Size = new System.Drawing.Size(299, 19);
            this.ReNewPsw_textBox.TabIndex = 1;
            // 
            // PswBack_button
            // 
            this.PswBack_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PswBack_button.Location = new System.Drawing.Point(291, 268);
            this.PswBack_button.Name = "PswBack_button";
            this.PswBack_button.Size = new System.Drawing.Size(75, 23);
            this.PswBack_button.TabIndex = 5;
            this.PswBack_button.Text = "戻る";
            this.PswBack_button.UseVisualStyleBackColor = true;
            this.PswBack_button.Click += new System.EventHandler(this.PswBack_button_Click);
            // 
            // PswNext_button
            // 
            this.PswNext_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PswNext_button.Location = new System.Drawing.Point(372, 268);
            this.PswNext_button.Name = "PswNext_button";
            this.PswNext_button.Size = new System.Drawing.Size(75, 23);
            this.PswNext_button.TabIndex = 4;
            this.PswNext_button.Text = "次へ";
            this.PswNext_button.UseVisualStyleBackColor = true;
            this.PswNext_button.Click += new System.EventHandler(this.PswNext_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "新しいパスワード";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "確認入力";
            // 
            // Backupcode_textBox
            // 
            this.Backupcode_textBox.BackColor = System.Drawing.Color.White;
            this.Backupcode_textBox.Location = new System.Drawing.Point(109, 136);
            this.Backupcode_textBox.Name = "Backupcode_textBox";
            this.Backupcode_textBox.ReadOnly = true;
            this.Backupcode_textBox.Size = new System.Drawing.Size(299, 19);
            this.Backupcode_textBox.TabIndex = 8;
            // 
            // CreateBackupcode_button
            // 
            this.CreateBackupcode_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateBackupcode_button.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.CreateBackupcode_button.Location = new System.Drawing.Point(359, 161);
            this.CreateBackupcode_button.Name = "CreateBackupcode_button";
            this.CreateBackupcode_button.Size = new System.Drawing.Size(49, 40);
            this.CreateBackupcode_button.TabIndex = 9;
            this.CreateBackupcode_button.Text = "🔁";
            this.CreateBackupcode_button.UseVisualStyleBackColor = true;
            this.CreateBackupcode_button.Click += new System.EventHandler(this.CreateBackupcode_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "バックアップコード";
            // 
            // Psw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CreateBackupcode_button);
            this.Controls.Add(this.Backupcode_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PswBack_button);
            this.Controls.Add(this.PswNext_button);
            this.Controls.Add(this.ReNewPsw_textBox);
            this.Controls.Add(this.NewPsw_textBox);
            this.Name = "Psw";
            this.Size = new System.Drawing.Size(450, 294);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewPsw_textBox;
        private System.Windows.Forms.TextBox ReNewPsw_textBox;
        private System.Windows.Forms.Button PswBack_button;
        private System.Windows.Forms.Button PswNext_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Backupcode_textBox;
        private System.Windows.Forms.Button CreateBackupcode_button;
        private System.Windows.Forms.Label label3;
    }
}
