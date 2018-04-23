using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FSys;

namespace SCLIP.View.Config.Setup
{
    public partial class Finish : UserControl
    {
        private FileIO.Stream stream;


        public Finish()
        {
            InitializeComponent();
        }

        private void Finish_button_Click(object sender, EventArgs e)
        {
            Save();

            ConfigForm.Setuped = true;

            Application.Restart();
        }

        private void Save()
        {

            string tmp;


            for (int i = 0; i < 2; i++)
                Group.Create(InternalSystem.Paths.Directorys[i]);


            for (int i = 0; i < 2; i++)
                FileIO.Create(InternalSystem.Paths.Files[i]);



            


            //LoginKey
            stream = new FileIO.Stream(InternalSystem.Paths.Files[0]);

            tmp = GeneralPurpose.Cipher.Rdm();

            stream.Write(GeneralPurpose.Cipher.HashCompute(ConfigForm._passwdView.Passwd_textBox.Text, tmp) + ',' + tmp);

            stream.Close();


            //EncKey
            stream = new FileIO.Stream(InternalSystem.Paths.Files[1]);

            tmp = GeneralPurpose.Cipher.Rdm() + "," + GeneralPurpose.Cipher.Rdm();

            stream.Write(GeneralPurpose.Cipher.Encrypt(ConfigForm._passwdView.Passwd_textBox.Text,tmp.Split(',')[0], tmp.Split(',')[1]) + ',' + tmp.Split(',')[0]);

            stream.Close();

        }
    }
}
