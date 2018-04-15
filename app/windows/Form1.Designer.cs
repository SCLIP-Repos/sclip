namespace SCLIP
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Item_button = new System.Windows.Forms.ToolStripDropDownButton();
            this.New_button = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_button = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete_button = new System.Windows.Forms.ToolStripMenuItem();
            this.Logout_button = new System.Windows.Forms.ToolStripButton();
            this.Config_button = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Item_listBox = new System.Windows.Forms.ListBox();
            this.Base_panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 849F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.429072F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.57093F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1050, 571);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Item_button,
            this.Config_button,
            this.Logout_button});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1050, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Item_button
            // 
            this.Item_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Item_button.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New_button,
            this.Edit_button,
            this.Delete_button});
            this.Item_button.Image = ((System.Drawing.Image)(resources.GetObject("Item_button.Image")));
            this.Item_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Item_button.Name = "Item_button";
            this.Item_button.Size = new System.Drawing.Size(46, 22);
            this.Item_button.Text = "ITEM";
            // 
            // New_button
            // 
            this.New_button.BackColor = System.Drawing.Color.White;
            this.New_button.Name = "New_button";
            this.New_button.Size = new System.Drawing.Size(180, 22);
            this.New_button.Text = "New";
            this.New_button.Click += new System.EventHandler(this.New_button_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.BackColor = System.Drawing.Color.White;
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(180, 22);
            this.Edit_button.Text = "Edit";
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.White;
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(180, 22);
            this.Delete_button.Text = "Delete";
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Logout_button
            // 
            this.Logout_button.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Logout_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Logout_button.Image = ((System.Drawing.Image)(resources.GetObject("Logout_button.Image")));
            this.Logout_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Logout_button.Name = "Logout_button";
            this.Logout_button.Size = new System.Drawing.Size(49, 22);
            this.Logout_button.Text = "Logout";
            this.Logout_button.Click += new System.EventHandler(this.Logout_button_Click);
            // 
            // Config_button
            // 
            this.Config_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Config_button.Image = ((System.Drawing.Image)(resources.GetObject("Config_button.Image")));
            this.Config_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Config_button.Name = "Config_button";
            this.Config_button.Size = new System.Drawing.Size(46, 22);
            this.Config_button.Text = "Config";
            this.Config_button.Click += new System.EventHandler(this.Config_button_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.386973F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.61303F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.Item_listBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Base_panel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 34);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1044, 534);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // Item_listBox
            // 
            this.Item_listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Item_listBox.FormattingEnabled = true;
            this.Item_listBox.ItemHeight = 12;
            this.Item_listBox.Location = new System.Drawing.Point(3, 3);
            this.Item_listBox.Name = "Item_listBox";
            this.Item_listBox.Size = new System.Drawing.Size(92, 528);
            this.Item_listBox.TabIndex = 0;
            // 
            // Base_panel
            // 
            this.Base_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Base_panel.Location = new System.Drawing.Point(101, 3);
            this.Base_panel.Name = "Base_panel";
            this.Base_panel.Size = new System.Drawing.Size(940, 528);
            this.Base_panel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 571);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "SCLIP";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton Item_button;
        private System.Windows.Forms.ToolStripMenuItem New_button;
        private System.Windows.Forms.ToolStripMenuItem Edit_button;
        private System.Windows.Forms.ToolStripMenuItem Delete_button;
        private System.Windows.Forms.ToolStripButton Config_button;
        private System.Windows.Forms.ToolStripButton Logout_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListBox Item_listBox;
        private System.Windows.Forms.Panel Base_panel;
    }
}

