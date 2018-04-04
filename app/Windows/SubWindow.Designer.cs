namespace SCLIP
{
    partial class SubWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Base_panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Base_panel
            // 
            this.Base_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Base_panel.Location = new System.Drawing.Point(0, 0);
            this.Base_panel.Name = "Base_panel";
            this.Base_panel.Size = new System.Drawing.Size(645, 407);
            this.Base_panel.TabIndex = 0;
            // 
            // SubWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 407);
            this.Controls.Add(this.Base_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubWindow";
            this.Text = "$safeprojectname$";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Base_panel;
    }
}