﻿using System;
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
            if (MainWindow.SignedIN == false)
            {
                Registration objRegistartion = new Registration();
                objRegistartion.ShowDialog();
                objRegistartion.Close();
                this.Close();

            }
            else
            {
                MainWindow.SignedIN = false;
                this.Close();
            }
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

        private void InputPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            //this.InputPassword.Text = "*";
            //string pas = this.InputPassword.Text;
            //this.InputPassword.Text = string.Empty;
            //for (int i = 0; i < pas.Length; i++)
            //{
            //    this.InputPassword.Text += "*";
            //}
        }

        private void checkBoxShowPassword_Checked(object sender, RoutedEventArgs e)
        {
            //this.InputPassword.Text = '\0';
            this.passwBox.Visibility = Visibility.Collapsed;
            this.InputPassword.Visibility = Visibility.Visible;
            this.InputPassword.Text = this.passwBox.Password;
        }

        private void checkBoxShowPassword_Unchecked(object sender, RoutedEventArgs e)
        {
            //this.InputPassword.Text = '*';
            this.passwBox.Visibility = Visibility.Visible;
            this.InputPassword.Visibility = Visibility.Collapsed;
            this.passwBox.Password = this.InputPassword.Text;
        }
    }
}
