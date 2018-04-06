namespace $safeprojectname$.View.Setup
{
    partial class Passwd
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
            this.Passwd_textBox = new System.Windows.Forms.TextBox();
            this.ReEnter_textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Next_button = new System.Windows.Forms.Button();
            this.EP_checkBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Passwd_textBox
            // 
            this.Passwd_textBox.PasswordChar = '●';
            this.Passwd_textBox.BackColor = System.Drawing.Color.White;
            this.Passwd_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Passwd_textBox.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.Passwd_textBox.Location = new System.Drawing.Point(221, 50);
            this.Passwd_textBox.Name = "Passwd_textBox";
            this.Passwd_textBox.Size = new System.Drawing.Size(369, 27);
            this.Passwd_textBox.TabIndex = 0;
            // 
            // ReEnter_textBox
            // 
            ReEnter_textBox.PasswordChar = '●'; 
            this.ReEnter_textBox.BackColor = System.Drawing.Color.White;
            this.ReEnter_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReEnter_textBox.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ReEnter_textBox.Location = new System.Drawing.Point(221, 112);
            this.ReEnter_textBox.Name = "ReEnter_textBox";
            this.ReEnter_textBox.Size = new System.Drawing.Size(369, 27);
            this.ReEnter_textBox.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.32468F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.67533F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(720, 385);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EP_checkBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Passwd_textBox);
            this.panel1.Controls.Add(this.ReEnter_textBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 284);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(111, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label2.Location = new System.Drawing.Point(118, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Re enter";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Next_button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 293);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 89);
            this.panel2.TabIndex = 1;
            // 
            // Next_button
            // 
            this.Next_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next_button.Location = new System.Drawing.Point(619, 51);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(95, 35);
            this.Next_button.TabIndex = 3;
            this.Next_button.Text = "NEXT";
            this.Next_button.UseVisualStyleBackColor = true;
            this.Next_button.Click += new System.EventHandler(this.Next_button_Click);
            // 
            // EP_checkBox
            // 
            this.EP_checkBox.AutoSize = true;
            this.EP_checkBox.Location = new System.Drawing.Point(221, 169);
            this.EP_checkBox.Name = "EP_checkBox";
            this.EP_checkBox.Size = new System.Drawing.Size(109, 16);
            this.EP_checkBox.TabIndex = 4;
            this.EP_checkBox.Text = "Export password";
            this.EP_checkBox.UseVisualStyleBackColor = true;
            // 
            // Passwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Passwd";
            this.Size = new System.Drawing.Size(720, 385);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Passwd_textBox;
        private System.Windows.Forms.TextBox ReEnter_textBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Next_button;
        private System.Windows.Forms.CheckBox EP_checkBox;
    }
}
