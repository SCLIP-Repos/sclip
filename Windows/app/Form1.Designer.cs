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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ItemNew_button = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemEdit_button = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemDelete_button = new System.Windows.Forms.ToolStripMenuItem();
            this.Config_button = new System.Windows.Forms.ToolStripButton();
            this.Logout_button = new System.Windows.Forms.ToolStripButton();
            this.Item_listBox = new System.Windows.Forms.ListBox();
            this.Base_panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.45943F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.54057F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.340568F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.65943F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1023, 599);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.52114F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.47886F));
            this.tableLayoutPanel2.Controls.Add(this.Item_listBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Base_panel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1017, 568);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.Config_button,
            this.Logout_button});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1023, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemNew_button,
            this.ItemEdit_button,
            this.ItemDelete_button});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(43, 22);
            this.toolStripDropDownButton1.Text = "Item";
            // 
            // ItemNew_button
            // 
            this.ItemNew_button.Name = "ItemNew_button";
            this.ItemNew_button.Size = new System.Drawing.Size(180, 22);
            this.ItemNew_button.Text = "New";
            // 
            // ItemEdit_button
            // 
            this.ItemEdit_button.Name = "ItemEdit_button";
            this.ItemEdit_button.Size = new System.Drawing.Size(180, 22);
            this.ItemEdit_button.Text = "Edit";
            // 
            // ItemDelete_button
            // 
            this.ItemDelete_button.Name = "ItemDelete_button";
            this.ItemDelete_button.Size = new System.Drawing.Size(180, 22);
            this.ItemDelete_button.Text = "Delete";
            // 
            // Config_button
            // 
            this.Config_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Config_button.Image = ((System.Drawing.Image)(resources.GetObject("Config_button.Image")));
            this.Config_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Config_button.Name = "Config_button";
            this.Config_button.Size = new System.Drawing.Size(46, 22);
            this.Config_button.Text = "Config";
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
            // 
            // Item_listBox
            // 
            this.Item_listBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.Item_listBox.FormattingEnabled = true;
            this.Item_listBox.ItemHeight = 12;
            this.Item_listBox.Location = new System.Drawing.Point(3, 3);
            this.Item_listBox.Name = "Item_listBox";
            this.Item_listBox.Size = new System.Drawing.Size(101, 562);
            this.Item_listBox.TabIndex = 0;
            // 
            // Base_panel
            // 
            this.Base_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Base_panel.Location = new System.Drawing.Point(110, 3);
            this.Base_panel.Name = "Base_panel";
            this.Base_panel.Size = new System.Drawing.Size(904, 562);
            this.Base_panel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 599);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "SCLIP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem ItemNew_button;
        private System.Windows.Forms.ToolStripMenuItem ItemEdit_button;
        private System.Windows.Forms.ToolStripMenuItem ItemDelete_button;
        private System.Windows.Forms.ToolStripButton Config_button;
        private System.Windows.Forms.ToolStripButton Logout_button;
        private System.Windows.Forms.ListBox Item_listBox;
        private System.Windows.Forms.Panel Base_panel;
    }
}

