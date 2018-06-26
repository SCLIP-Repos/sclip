using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SCLIP.View.Sets
{
    /// <summary>
    /// Setup_psw.xaml の相互作用ロジック
    /// </summary>
    public partial class Setup_psw : Page
    {
        public Setup_psw()
        {
            InitializeComponent();
        }

        private void Next_Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (Psw_PasswordBox.Password.Length < 5)
            {
                MessageBox.Show("Password must be set to 5 digits or more.");

                return;

            }

            if (PswRe_PasswordBox.Password != Psw_PasswordBox.Password)
            {
                MessageBox.Show("It does not match the confirmation input.");

                return;
            }


            string tmp = null;

            CommonAct.Ciphers ciphers = new CommonAct.Ciphers() ;


            tmp = Guid.NewGuid().ToString("N").Substring(20);




            Act.Sets.Setup setup = new Act.Sets.Setup();



            setup.Save(ciphers.HashCode(Psw_PasswordBox.Password, tmp),Act.Sets.Setup.Target.AuthenticationKey);

            setup.Save(tmp, Act.Sets.Setup.Target.AuthenticationSalt);




            tmp = Guid.NewGuid().ToString("N").Substring(20);


            setup.Save(ciphers.AesEncrypt(Psw_PasswordBox.Password, tmp, Guid.NewGuid().ToString("N").Substring(20)),Act.Sets.Setup.Target.EncKey);

            setup.Save(tmp, Act.Sets.Setup.Target.EncIv);


            Application.Current.Shutdown(1);
        }

        private void Back03_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Setup_agree());
        }

        private void CreateBackupcode_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
