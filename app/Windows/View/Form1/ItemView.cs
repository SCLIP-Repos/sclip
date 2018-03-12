using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace $safeprojectname$.View.Form1
{
    public partial class ItemView : UserControl
    {
        public ItemView()
        {
            InitializeComponent();
        }

        public  void SET(string ServiceName,string URL,string Username,string Mail,string TEL,string Passwd,string Memo)
        {
            ServiceName_label.Text = ServiceName;

            URL_linkLabel.Text = URL;

            Username_label.Text = Username;

            Mail_label.Text = Mail;

            TEL_label.Text = TEL;

            Passwd_label.Text = Passwd;

            Memo_richTextBox.Text = Memo;
        }

        public void Clear()
        {
            SET(null, null, null, null, null, null, null);
        }

        /*PRIVATE*/


        /*EVENT DRIVE*/

        private void URL_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(URL_linkLabel.Text);
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            Clear();

            $safeprojectname$.Form1.View_Switch($safeprojectname$.Form1.View_Chanel.Top);
        }
    }
}
