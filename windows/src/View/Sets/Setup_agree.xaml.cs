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
    /// Setup_agree.xaml の相互作用ロジック
    /// </summary>
    public partial class Setup_agree : Page
    {
        public Setup_agree()
        {
            InitializeComponent();
        }

        private void Next_Button_Click(object sender, RoutedEventArgs e)
        {
            if(Agree_Check.IsChecked == false)
            {
                MessageBox.Show("It can not be used unless you agree with the OSS license.");
                return;
            }

            NavigationService.Navigate(new Setup_psw());
        }
    }
}
