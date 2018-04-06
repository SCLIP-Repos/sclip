using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$.View.Item
{
    public partial class Control : UserControl
    {
        public Control()
        {
            InitializeComponent();
        }

        public void SET(string Service,string URL,string Nicname,string ID,string Passwd,string Mail,string TEL,string Memo)
        {
            Service_textBox.Text = Service;

            URL_textBox.Text = URL;

            Nicname_textBox.Text = Nicname;

            ID_textBox.Text = ID;

            Passwd_textBox.Text = Passwd;

            Mail_textBox.Text = Mail;

            TEL_textBox.Text = TEL;

            Memo_richTextBox.Text = Memo;
        }
    }
}
