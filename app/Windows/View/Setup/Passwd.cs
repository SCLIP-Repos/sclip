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
using CipherModule;
using CipherModule.Fake;

namespace $safeprojectname$.View.Setup
{
    public partial class Passwd : UserControl
    {
        public Passwd()
        {
            InitializeComponent();
        }

        private void Next_button_Click(object sender, EventArgs e)
        {

            //パスワードが規則にあって設定されたか?
            isPasswd();
            
            //パスワードのエクスポート処理
            ExportPsswd();


            //一時的にセキュリティ関連の設定をSetup.Tmp.csに格納
            TmpSave();

        }

        



        private void isPasswd()
        {
            if (Passwd_textBox.Text.Length < 5)
            {
                MessageBox.Show("Password must be 5 digits or more.");
                return;
            }

            if (Passwd_textBox.Text != RePasswd_textBox.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            $safeprojectname$.Setup.SwitchView(4);

        }


        private void ExportPsswd()
        {
            if (PasswdExport_checkBox.Checked == true)
            {
                Act.Setup setup = new Act.Setup();
                
                setup.ExportKey(Passwd_textBox.Text, PswExporttype_checkBox.Checked);
            }
        }

        private void TmpSave()
        {
            
            Act.Setup.Tmp.LoginKey = Passwd_textBox.Text;

            Act.Setup.Tmp.LoginSalt = SimpleRandom.Create();

            Act.Setup.Tmp.EncryptKey = SimpleRandom.Create();

            Act.Setup.Tmp.EncryptIv = SimpleRandom.Create();

        }

    }
}
