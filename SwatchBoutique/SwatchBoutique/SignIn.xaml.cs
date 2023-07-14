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
using System.Windows.Shapes;

namespace SwatchBoutique
{
    /// <summary>
    /// Interaction logic for SignIn.xaml
    /// </summary>
    public partial class SignIn : Window
    {
        public List<USER> users = new List<USER>();

        public SignIn()
        {
            InitializeComponent();
            users = USER.LoadUsers();
            if (MainWindow.SignedIN == true)
            {
                this.InputEmail.Visibility = Visibility.Hidden;
                this.InputPassword.Visibility = Visibility.Hidden;
                this.labelEmail.Visibility = Visibility.Hidden;
                this.labelPassword.Visibility = Visibility.Hidden;
                this.checkBoxShowPassword.Visibility = Visibility.Hidden;
                this.buttonSIGN.Visibility = Visibility.Hidden;
                this.imageAccount.Visibility = Visibility.Visible;
                this.buttonRegistration.Content = "Log Out";
            }

        }

        



        private void Registration_click(object sender, RoutedEventArgs e)
        {
            Registration objRegistartion = new Registration();
            objRegistartion.ShowDialog();
            objRegistartion.Close();
            this.Close();
        }

        private void buttonSIGN_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < this.users.Count; i++)
            {
                if (this.InputPassword.Text == this.users[i].Password && this.InputEmail.Text == this.users[i].Email)
                {
                    MainWindow.SignedIN = true;
                    this.Close();
                }
               

            }
        }
    }
}
