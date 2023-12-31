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
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public List<USER> users { get; set; } = new List<USER>();
        
        public Registration()
        {
            InitializeComponent();
            this.users = USER.LoadUsers();
            
            
        }

        private void CANCEL_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonOKregistration_click(object sender, RoutedEventArgs e)
        {
            string NamE = this.NametextBox.Text;
            string SurnamE = this.SurnametextBox.Text;
            string EmaiL = this.EmailTextBox.Text;
            string PassworD = this.PasswordTextBox.Text;
            string BankCarD = this.BankCardTextBox.Text;
            bool ForBankCard = true;
            if (string.IsNullOrEmpty(NamE) == true && string.IsNullOrWhiteSpace(NamE) == true
                || string.IsNullOrEmpty(SurnamE) == true && string.IsNullOrWhiteSpace(SurnamE) == true
                || string.IsNullOrEmpty(EmaiL) == true && string.IsNullOrWhiteSpace(EmaiL) == true
                || string.IsNullOrEmpty(PassworD) == true && string.IsNullOrWhiteSpace(PassworD) == true
                || string.IsNullOrEmpty(BankCarD) == true && string.IsNullOrWhiteSpace(BankCarD) == true)
            {
                MessageBox.Show("Fields couldnt be empty");
                return;
            }
            if (char.IsLower(NamE[0]) == true || char.IsLower(SurnamE[0]) == true)
            {
                MessageBox.Show("Name and Surname must start with Upper letter");
                return;
            }
            if (EmaiL.Contains("@") == false || EmaiL.Contains(".") == false || char.IsLetter(EmaiL[0]) == false)
            {
                MessageBox.Show("Incorrect EMAIL");
                return;
            }
            if (this.PasswordTextBox.Text.Length < 8)
            {
                MessageBox.Show("Password must be minimum 8 elements");
                return;
            }
            for (int i = 0; i < BankCarD.Length; i++)
            {
                if (char.IsDigit(BankCarD[i]) == false)
                {
                    ForBankCard = false;
                }
            }
            if (ForBankCard == false || BankCarD.Length < 8)
            {
                MessageBox.Show("Incorrect Bank Card ID");
                return;
            }
            else
            {
                USER user = new USER()
                {
                    Name = this.NametextBox.Text,
                    Surname = this.SurnametextBox.Text,
                    Email = this.EmailTextBox.Text,
                    Password = this.PasswordTextBox.Text,
                    BankCard = int.Parse(this.BankCardTextBox.Text),
                };

                this.users.Add(user);

                user?.SaveToJson(this.users);
                this.Close();
            }

            
            
        }


        


    }
}
