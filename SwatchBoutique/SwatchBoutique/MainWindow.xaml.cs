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

namespace SwatchBoutique
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double WindowHeight { get; set; } = 577;
        public double WindowWidth { get; set; } = 583;
        public static bool SignedIN = false;
        public static bool Boughted = false;
        public System.Windows.Media.ImageSource Icon { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            this.buttonShoppingBag.IsEnabled = false;
        }

        

        private void button_Click(object sender, RoutedEventArgs e)
        {

            CollectionWindow objWomen = new CollectionWindow();
            CollectionWindow objMen = new CollectionWindow("MEN");
            SignIn objSIgn = new SignIn();
            ShoppingBag objShoppingBag = new ShoppingBag();
            if ((sender as Button).Name == "buttonWomen")
            {
                Console.WriteLine("woman");
                objWomen.ShowDialog();
            }
            else if ((sender as Button).Name == "buttonMen")
            {

                objMen.ShowDialog();
            }
            else if((sender as Button).Name == "buttonSignIn") 
            { 
                objSIgn.ShowDialog();
                if (MainWindow.SignedIN == true)
                {

                    this.buttonShoppingBag.IsEnabled = true;
                    this.buttonSignIn.Content = "🤠";

                }
                else
                {
                    this.buttonSignIn.Content = "SIGN IN";
                    this.buttonShoppingBag.IsEnabled = false;
                }
            }
            else if ((sender as Button).Name == "buttonShoppingBag")
            {
                objShoppingBag.ShowDialog();
            }

            objShoppingBag.Close();
            objMen.Close();
            objWomen.Close();
            objSIgn.Close();
        }

        
    }
}
