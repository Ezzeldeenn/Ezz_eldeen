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
    /// Interaction logic for log_in.xaml
    /// </summary>
    public partial class log_in : Page
    {
        Project_with_usEntities db = new Project_with_usEntities();
        home home = new home();
        Forget_password ff = new Forget_password();
        Sign_up_xaml siso = new Sign_up_xaml();
        public static int tUse_id = 0;


        public log_in()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          Sign_up_xaml sign_Up_Xaml = new Sign_up_xaml();
            this.NavigationService.Navigate(sign_Up_Xaml);  
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           var log= db.Useres.FirstOrDefault(x=>x.Email==Email_txt.Text &&x.passworde == password_txt.Text);
            if (log != null)
            {
                tUse_id = log.Use_id;
                home n = new home();
                this.NavigationService.Navigate(n);

                password_txt.Text= Email_txt.Text=string.Empty;
            }
            else
                MessageBox.Show("Please enter value يا ابن الجزمه");

        }



        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Forget_password n = new Forget_password();
            this.NavigationService.Navigate(n); 
        }
    }
}
