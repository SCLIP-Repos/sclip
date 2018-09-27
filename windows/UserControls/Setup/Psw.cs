using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCLIP.UserControls.Setup
{
    public partial class Psw : UserControl
    {
        public Psw()
        {
            InitializeComponent();
        }

        private void CreateBackupcode_button_Click(object sender, EventArgs e)
        {

            Backupcode_textBox.Text = Guid.NewGuid().ToString("N").Substring(16);
        }

        private void PswNext_button_Click(object sender, EventArgs e)
        {
            if (NewPsw_textBox.Text != ReNewPsw_textBox.Text)
            {
                MessageBox.Show("確認入力と一致しません。");

                return;
            }

            if (NewPsw_textBox.Text.Length < 5)
            {
                MessageBox.Show("パスワードは5桁以上で設定する必要があります。");

                return;
            }

            if (Backupcode_textBox.Text == null || Backupcode_textBox.Text == String.Empty)
            {

                MessageBox.Show("バックアップコードは必ず作成する必要があります。");

                return;
            }


            for (int i = 0; i < 2; i++)
                Directory.CreateDirectory(Paths.Dirs[i]);


            for (int i = 0; i < 4; i++)
                using (var fc = File.Create(Paths.Files[i])) { }




            Act.Sets.Authentication authentication = new Act.Sets.Authentication();

            authentication.Save(NewPsw_textBox.Text, "*");



            Act.Sets.Itemlock itemlock = new Act.Sets.Itemlock();

            itemlock.Save(NewPsw_textBox.Text, Guid.NewGuid().ToString("N").Substring(16));



            Act.Sets.Backupcode backupcode = new Act.Sets.Backupcode();

            backupcode.Save(NewPsw_textBox.Text, Guid.NewGuid().ToString("N").Substring(16));

            Application.Restart();
        }

        private void PswBack_button_Click(object sender, EventArgs e)
        {
            SetupForm.Switch(SetupForm.SelectControl.Agree);
        }
    }
}
