namespace $safeprojectname$
{
    partial class Form1
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Lock_pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ItemControl_panel = new System.Windows.Forms.Panel();
            this.Refresh_button = new System.Windows.Forms.Button();
            this.New_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.View_panel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ItemList_panel = new System.Windows.Forms.Panel();
            this.ItemList_listView = new System.Windows.Forms.ListView();
            this.ItemSearch_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Lock_pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ItemControl_panel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.ItemList_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lock_pictureBox
            // 
            this.Lock_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Lock_pictureBox.Image")));
            this.Lock_pictureBox.Location = new System.Drawing.Point(3, 50);
            this.Lock_pictureBox.Name = "Lock_pictureBox";
            this.Lock_pictureBox.Size = new System.Drawing.Size(44, 50);
            this.Lock_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Lock_pictureBox.TabIndex = 4;
            this.Lock_pictureBox.TabStop = false;
            this.Lock_pictureBox.Click += new System.EventHandler(this.Lock_pictureBox_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Lock_pictureBox);
            this.panel1.Location = new System.Drawing.Point(12, 514);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 100);
            this.panel1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.406647F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.59335F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1023, 623);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ItemControl_panel);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(79, 617);
            this.panel2.TabIndex = 0;
            // 
            // ItemControl_panel
            // 
            this.ItemControl_panel.Controls.Add(this.Refresh_button);
            this.ItemControl_panel.Controls.Add(this.New_button);
            this.ItemControl_panel.Controls.Add(this.Delete_button);
            this.ItemControl_panel.Controls.Add(this.Edit_button);
            this.ItemControl_panel.Location = new System.Drawing.Point(3, 3);
            this.ItemControl_panel.Name = "ItemControl_panel";
            this.ItemControl_panel.Size = new System.Drawing.Size(71, 216);
            this.ItemControl_panel.TabIndex = 9;
            // 
            // Refresh_button
            // 
            this.Refresh_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh_button.Location = new System.Drawing.Point(3, 164);
            this.Refresh_button.Name = "Refresh_button";
            this.Refresh_button.Size = new System.Drawing.Size(62, 34);
            this.Refresh_button.TabIndex = 9;
            this.Refresh_button.Text = "Refresh";
            this.Refresh_button.UseVisualStyleBackColor = true;
            this.Refresh_button.Click += new System.EventHandler(this.Refresh_button_Click);
            // 
            // New_button
            // 
            this.New_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.New_button.Location = new System.Drawing.Point(3, 3);
            this.New_button.Name = "New_button";
            this.New_button.Size = new System.Drawing.Size(62, 34);
            this.New_button.TabIndex = 6;
            this.New_button.Text = "NEW";
            this.New_button.UseVisualStyleBackColor = true;
            this.New_button.Click += new System.EventHandler(this.New_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_button.Location = new System.Drawing.Point(3, 106);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(62, 34);
            this.Delete_button.TabIndex = 8;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_button.Location = new System.Drawing.Point(3, 54);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(62, 34);
            this.Edit_button.TabIndex = 7;
            this.Edit_button.Text = "EDIT";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.34764F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.65236F));
            this.tableLayoutPanel2.Controls.Add(this.View_panel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(88, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(932, 617);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // View_panel
            // 
            this.View_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.View_panel.Location = new System.Drawing.Point(173, 3);
            this.View_panel.Name = "View_panel";
            this.View_panel.Size = new System.Drawing.Size(756, 611);
            this.View_panel.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ItemList_panel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(164, 611);
            this.panel3.TabIndex = 0;
            // 
            // ItemList_panel
            // 
            this.ItemList_panel.Controls.Add(this.ItemList_listView);
            this.ItemList_panel.Controls.Add(this.ItemSearch_textBox);
            this.ItemList_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemList_panel.Location = new System.Drawing.Point(0, 0);
            this.ItemList_panel.Name = "ItemList_panel";
            this.ItemList_panel.Size = new System.Drawing.Size(164, 611);
            this.ItemList_panel.TabIndex = 0;
            // 
            // ItemList_listView
            // 
            this.ItemList_listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemList_listView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ItemList_listView.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ItemList_listView.Location = new System.Drawing.Point(0, 37);
            this.ItemList_listView.Name = "ItemList_listView";
            this.ItemList_listView.Size = new System.Drawing.Size(164, 574);
            this.ItemList_listView.TabIndex = 1;
            this.ItemList_listView.UseCompatibleStateImageBehavior = false;
            this.ItemList_listView.Click += new System.EventHandler(this.ItemList_listView_Click);
            // 
            // ItemSearch_textBox
            // 
            this.ItemSearch_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemSearch_textBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ItemSearch_textBox.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.ItemSearch_textBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.ItemSearch_textBox.Location = new System.Drawing.Point(0, 0);
            this.ItemSearch_textBox.Name = "ItemSearch_textBox";
            this.ItemSearch_textBox.Size = new System.Drawing.Size(164, 18);
            this.ItemSearch_textBox.TabIndex = 0;
            this.ItemSearch_textBox.Text = "SEARCH";
            this.ItemSearch_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 623);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "$safeprojectname$";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Lock_pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ItemControl_panel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ItemList_panel.ResumeLayout(false);
            this.ItemList_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Lock_pictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel ItemControl_panel;
        private System.Windows.Forms.Button New_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel View_panel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel ItemList_panel;
        private System.Windows.Forms.TextBox ItemSearch_textBox;
        public System.Windows.Forms.ListView ItemList_listView;
        private System.Windows.Forms.Button Refresh_button;
    }
}

