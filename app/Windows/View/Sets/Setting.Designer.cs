namespace View.Sets
{
    partial class Setting
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ReNewPasswd_textBox = new System.Windows.Forms.TextBox();
            this.NewPasswd_textBox = new System.Windows.Forms.TextBox();
            this.OK_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ViewPasswd_label = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(645, 407);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ViewPasswd_label);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Cancel_button);
            this.tabPage1.Controls.Add(this.OK_button);
            this.tabPage1.Controls.Add(this.NewPasswd_textBox);
            this.tabPage1.Controls.Add(this.ReNewPasswd_textBox);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(637, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Password";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(637, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Uninstall";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.textBox1.Location = new System.Drawing.Point(183, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReNewPasswd_textBox
            // 
            this.ReNewPasswd_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReNewPasswd_textBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.ReNewPasswd_textBox.Location = new System.Drawing.Point(183, 155);
            this.ReNewPasswd_textBox.Name = "ReNewPasswd_textBox";
            this.ReNewPasswd_textBox.Size = new System.Drawing.Size(339, 23);
            this.ReNewPasswd_textBox.TabIndex = 1;
            this.ReNewPasswd_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewPasswd_textBox
            // 
            this.NewPasswd_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewPasswd_textBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.NewPasswd_textBox.Location = new System.Drawing.Point(183, 114);
            this.NewPasswd_textBox.Name = "NewPasswd_textBox";
            this.NewPasswd_textBox.Size = new System.Drawing.Size(339, 23);
            this.NewPasswd_textBox.TabIndex = 1;
            this.NewPasswd_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OK_button
            // 
            this.OK_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OK_button.Location = new System.Drawing.Point(550, 346);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(83, 31);
            this.OK_button.TabIndex = 2;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cancel_button.Location = new System.Drawing.Point(461, 346);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(83, 31);
            this.Cancel_button.TabIndex = 3;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(95, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(62, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(71, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "RE Password";
            // 
            // ViewPasswd_label
            // 
            this.ViewPasswd_label.AutoSize = true;
            this.ViewPasswd_label.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.ViewPasswd_label.Location = new System.Drawing.Point(525, 116);
            this.ViewPasswd_label.Name = "ViewPasswd_label";
            this.ViewPasswd_label.Size = new System.Drawing.Size(21, 18);
            this.ViewPasswd_label.TabIndex = 7;
            this.ViewPasswd_label.Text = "👁";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Name = "Setting";
            this.Size = new System.Drawing.Size(645, 407);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox NewPasswd_textBox;
        private System.Windows.Forms.TextBox ReNewPasswd_textBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ViewPasswd_label;
    }
}
