using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
       
    public partial class Sign_up_xaml : Page

    {
        bool Stutes = false;

        public Sign_up_xaml()
        {
            InitializeComponent();
        }

        private void sign_up_Copy_Click(object sender, RoutedEventArgs e)
        {
           log_in log_In = new log_in();
            this.NavigationService.Navigate(log_In);
        }

        private void sign_up_Click(object sender, RoutedEventArgs e)
        {
            home re= new home();
            this.NavigationService.Navigate(re);
        }

        private void password_TextChanged(object sender, TextChangedEventArgs e)
        {
            string pass = password.Text;
            bool digit = false,
                letter = false,
                spishial_char = false;
            foreach(char c in pass)
            {
                if (pass == password.Text) 
                {
                    if (char.IsDigit(c))
                    {
                        digit = true;
                    }
                    if (char.IsLetter(c))
                    {
                        letter = true;
                    }
                    if (!char.IsLetterOrDigit(c))
                    {
                        spishial_char = true;
                    }
                    if (pass.Length > 4 && letter && spishial_char && digit)
                    {
                        Stutes = true;
                    }
                   
                }

               
            }
            
        }
    }
}
