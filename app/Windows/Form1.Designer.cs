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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ITEMADD_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ITEMEDIT_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ITEMDELETE_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.DIRECTORYADD_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DIRECTORYEDIT_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DIRECTORYDELETE_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AUTHENTICATION_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SETS_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LOGOUT_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.UserControlsView_panel = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton1,
            this.AUTHENTICATION_toolStripButton,
            this.SETS_toolStripButton,
            this.LOGOUT_toolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(976, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ITEMADD_ToolStripMenuItem,
            this.ITEMEDIT_ToolStripMenuItem,
            this.ITEMDELETE_ToolStripMenuItem1});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton1.Text = "ITEM";
            // 
            // ITEMADD_ToolStripMenuItem
            // 
            this.ITEMADD_ToolStripMenuItem.Name = "ITEMADD_ToolStripMenuItem";
            this.ITEMADD_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ITEMADD_ToolStripMenuItem.Text = "ADD";
            // 
            // ITEMEDIT_ToolStripMenuItem
            // 
            this.ITEMEDIT_ToolStripMenuItem.Name = "ITEMEDIT_ToolStripMenuItem";
            this.ITEMEDIT_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ITEMEDIT_ToolStripMenuItem.Text = "EDIT";
            // 
            // ITEMDELETE_ToolStripMenuItem1
            // 
            this.ITEMDELETE_ToolStripMenuItem1.Name = "ITEMDELETE_ToolStripMenuItem1";
            this.ITEMDELETE_ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.ITEMDELETE_ToolStripMenuItem1.Text = "DELETE";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DIRECTORYADD_ToolStripMenuItem,
            this.DIRECTORYEDIT_ToolStripMenuItem,
            this.DIRECTORYDELETE_ToolStripMenuItem});
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(83, 22);
            this.toolStripButton2.Text = "DIRECTORY";
            // 
            // DIRECTORYADD_ToolStripMenuItem
            // 
            this.DIRECTORYADD_ToolStripMenuItem.Name = "DIRECTORYADD_ToolStripMenuItem";
            this.DIRECTORYADD_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DIRECTORYADD_ToolStripMenuItem.Text = "ADD";
            // 
            // DIRECTORYEDIT_ToolStripMenuItem
            // 
            this.DIRECTORYEDIT_ToolStripMenuItem.Name = "DIRECTORYEDIT_ToolStripMenuItem";
            this.DIRECTORYEDIT_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DIRECTORYEDIT_ToolStripMenuItem.Text = "EDIT";
            // 
            // DIRECTORYDELETE_ToolStripMenuItem
            // 
            this.DIRECTORYDELETE_ToolStripMenuItem.Name = "DIRECTORYDELETE_ToolStripMenuItem";
            this.DIRECTORYDELETE_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DIRECTORYDELETE_ToolStripMenuItem.Text = "DELETE";
            // 
            // AUTHENTICATION_toolStripButton
            // 
            this.AUTHENTICATION_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AUTHENTICATION_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("AUTHENTICATION_toolStripButton.Image")));
            this.AUTHENTICATION_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AUTHENTICATION_toolStripButton.Name = "AUTHENTICATION_toolStripButton";
            this.AUTHENTICATION_toolStripButton.Size = new System.Drawing.Size(108, 22);
            this.AUTHENTICATION_toolStripButton.Text = "AUTHENTICATION";
            // 
            // SETS_toolStripButton
            // 
            this.SETS_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SETS_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SETS_toolStripButton.Image")));
            this.SETS_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SETS_toolStripButton.Name = "SETS_toolStripButton";
            this.SETS_toolStripButton.Size = new System.Drawing.Size(35, 22);
            this.SETS_toolStripButton.Text = "SETS";
            // 
            // LOGOUT_toolStripButton
            // 
            this.LOGOUT_toolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.LOGOUT_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LOGOUT_toolStripButton.ForeColor = System.Drawing.Color.Red;
            this.LOGOUT_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("LOGOUT_toolStripButton.Image")));
            this.LOGOUT_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LOGOUT_toolStripButton.Name = "LOGOUT_toolStripButton";
            this.LOGOUT_toolStripButton.Size = new System.Drawing.Size(59, 22);
            this.LOGOUT_toolStripButton.Text = "LOGOUT";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 724F));
            this.tableLayoutPanel1.Controls.Add(this.listView2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.UserControlsView_panel, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(976, 550);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(120, 544);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.White;
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.Location = new System.Drawing.Point(129, 3);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(120, 544);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // UserControlsView_panel
            // 
            this.UserControlsView_panel.BackColor = System.Drawing.Color.White;
            this.UserControlsView_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserControlsView_panel.Location = new System.Drawing.Point(255, 3);
            this.UserControlsView_panel.Name = "UserControlsView_panel";
            this.UserControlsView_panel.Size = new System.Drawing.Size(718, 544);
            this.UserControlsView_panel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 575);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "$safeprojectname$";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem ITEMADD_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ITEMEDIT_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ITEMDELETE_ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem DIRECTORYADD_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DIRECTORYEDIT_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DIRECTORYDELETE_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton AUTHENTICATION_toolStripButton;
        private System.Windows.Forms.ToolStripButton SETS_toolStripButton;
        private System.Windows.Forms.ToolStripButton LOGOUT_toolStripButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel UserControlsView_panel;
    }
}

