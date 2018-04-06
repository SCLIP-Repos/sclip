using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

<<<<<<< HEAD
using FSys;


namespace SCLIP.View.Item
{
    public partial class Control : UserControl
    {
        internal static bool EditMode = false;

=======
namespace $safeprojectname$.View.Item
{
    public partial class Control : UserControl
    {
>>>>>>> b27f45d06842ef02074930127f0fc5e0a8f3b40b
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
<<<<<<< HEAD

        private void OK_button_Click(object sender, EventArgs e)
        {
            if(FileIO.Exists(Act.Configuration.Control.Path.SavePath + Service_textBox.Text) && EditMode == false)
            {
                MessageBox.Show("It already exists.");
                return;
            }

            string tmp = Service_textBox.Text + "," + URL_textBox.Text + "," + Nicname_textBox.Text + "," + ID_textBox.Text + "," + Passwd_textBox.Text + "," + Mail_textBox.Text + "," + TEL_textBox.Text + "," + Memo_richTextBox.Text;

            string iv = Act.GeneralPurpose.Cipher.Rdm();

            tmp = Act.GeneralPurpose.Cipher.Encrypt(Act.Configuration.Tmp.EncryptKey, iv, tmp) + "," + iv;

            FileIO.Create(Act.Configuration.Control.Path.SavePath + Service_textBox.Text);

            FileIO.Stream stream = new FileIO.Stream(Act.Configuration.Control.Path.SavePath + Service_textBox.Text,FileIO.Stream.FileMode.Write);
            
            stream.Write(tmp);

           

            SET(null, null, null, null, null, null, null, null);
            Form1.Switch(Form1.Channel.Init);
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            SET(null, null, null, null, null, null, null,null);
            Form1.Switch(Form1.Channel.Init);
        }
=======
>>>>>>> b27f45d06842ef02074930127f0fc5e0a8f3b40b
    }
}
