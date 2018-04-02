using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCLIP.View.Top.Item
{
    public partial class ItemControl : UserControl
    {
        public ItemControl()
        {
            InitializeComponent();
        }

        public ItemControl(string Service,string URL,string Nicname,string ID,string Passwd,string Mail,string TEL,string Memo)
        {
            /*
            if(Service_textBox.Text)
            {
                Service_textBox.Text = Service;
            }
            */

            Service_textBox.Text = Service;

            URL_textBox.Text = URL;

            Nicname_textBox.Text = Nicname;

            ID_textBox.Text = ID;

            Passwd_textBox.Text = Passwd;

            Mail_textBox.Text = Mail;

            TEL_textBox.Text = TEL;

            Memo_richTextBox.Text = Memo;
        }


        /*Event Drive*/

        private void OK_button_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {

        }
    }
}
