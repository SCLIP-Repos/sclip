using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using System.Windows.Forms;

namespace SCLIP.View.Config.Setup
{
    public partial class Passwd : UserControl
    {
        public Passwd()
        {
            InitializeComponent();
        }


        private void Passwd_textBox_TextChanged(object sender, EventArgs e)
        {

            Strength_progressBar.Value = 0;


            /*
            if( ((Passwd_textBox.Text.Length >= 5 && Passwd_textBox.Text.Length <= 6) && Regex.IsMatch(Passwd_textBox.Text,"[0-9]")) || ( (Passwd_textBox.Text.Length >= 5 && Passwd_textBox.Text.Length <= 6)  && Regex.IsMatch(Passwd_textBox.Text, "[a-zA-Z]")) )
            {
                Strength_progressBar.Value = 10;
                Strength_label.Text = Properties.Resources.password_Strength_Weak;
            }
            else if(Passwd_textBox.Text.Length <= 7 && (Regex.IsMatch(Passwd_textBox.Text,"[a-zA-Z]") && Regex.IsMatch(Passwd_textBox.Text, "[0-9]") ))
            {
                Strength_progressBar.Value = 25;
                Strength_label.Text = Properties.Resources.password_Strength_Weak;
            }
            else if ( (Passwd_textBox.Text.Length > 7 &&  Regex.IsMatch(Passwd_textBox.Text, "[a-zA-Z]")  ) && Regex.IsMatch(Passwd_textBox.Text, "[0-9]") && (Regex.IsMatch(Passwd_textBox.Text, "[a-z]") && Regex.IsMatch(Passwd_textBox.Text, "[A-Z]")) )
            {
                Strength_progressBar.Value = 50;
                Strength_label.Text = Properties.Resources.password_Strength_LittleNice;
            }
            else if ( (Passwd_textBox.Text.Length > 7 && Regex.IsMatch(Passwd_textBox.Text, "[a-z]") && Regex.IsMatch(Passwd_textBox.Text, "[A-Z]") && Regex.IsMatch(Passwd_textBox.Text, "[0-9]")))
            {
                Strength_progressBar.Value = 100;
                Strength_label.Text = Properties.Resources.password_Strength_Strong;
            }
            */


            char[] tmp =
            {
                '!',
                '?',
                '*',
                '+',
                '@',
                '"',
                '`',
                '#',
                '$',
                '%',
                '&',
                '\\' ,
                '=',
                '-',
                '(',
                ')',
                '{',
                '}',
                '~',
                '^',
                '|'
            };

            GeneralPurpose.PasswdCheck passwdCheck = new GeneralPurpose.PasswdCheck(Passwd_textBox.Text);
            
            if(passwdCheck.Length(5))
            {
                Strength_progressBar.Value = 10;
                Strength_label.Text = Properties.Resources.password_Strength_Weak;
            }

            if (passwdCheck.Length(5) && passwdCheck.Check("[a-z]") && passwdCheck.Check("[A-Z]"))
            {
                Strength_progressBar.Value = 20;
                Strength_label.Text = Properties.Resources.password_Strength_Weak;
            }

            if (passwdCheck.Length(6) && passwdCheck.Check("[a-z]") && passwdCheck.Check("[A-Z]"))
            {
                Strength_progressBar.Value = 30;
                Strength_label.Text = Properties.Resources.password_Strength_Weak;
            }

            if (passwdCheck.Length(6) && passwdCheck.Check("[a-z]") && passwdCheck.Check("[A-Z]") && passwdCheck.isChar(tmp))
            {
                Strength_progressBar.Value = 50;
                Strength_label.Text = Properties.Resources.password_Strength_LittleNice;
            }


            if (passwdCheck.Length(8) && passwdCheck.Check("[a-z]") && passwdCheck.Check("[A-Z]") && passwdCheck.isChar(tmp))
            {
                Strength_progressBar.Value = 100;
                Strength_label.Text = Properties.Resources.password_Strength_Strong;
            }

        }

        private void NEXT_button_Click(object sender, EventArgs e)
        {
            if(Passwd_textBox.Text.Length < 5)
            {
                MessageBox.Show(Properties.Resources.passwod_NoLength);
            }

            ConfigForm.SwichView(ConfigForm.Channel.Log);
        }

    }
}
