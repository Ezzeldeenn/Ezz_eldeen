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

namespace Progect_Ezz
{
    /// <summary>
    /// Interaction logic for Forget_password.xaml
    /// </summary>
    public partial class Forget_password : Page
    {
        public Forget_password()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Sign_up_xaml sig = new Sign_up_xaml();
            this.NavigationService.Navigate(sig);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            home me = new home();
            this.NavigationService.Navigate(me);
        }
    }
}
