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

        //public ProduktClass pr = new ProduktClass("/Assets/men1.png", "Men", "8,000.00");
        public System.Windows.Media.ImageSource Icon { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            this.buttonShoppingBag.IsEnabled = false;
            //pr.SaveProduct(pr);
        }

        

        private void button_Click(object sender, RoutedEventArgs e)
        {         
            if ((sender as Button).Name == "buttonWomen")
            {
                CollectionWindow objWomen = new CollectionWindow();
                Console.WriteLine("woman");
                objWomen.ShowDialog();
                objWomen.Close();
            }
            else if ((sender as Button).Name == "buttonMen")
            {
                CollectionWindow objMen = new CollectionWindow("MEN");
                objMen.ShowDialog();
                objMen.Close();
            }
            else if((sender as Button).Name == "buttonSignIn") 
            {
                SignIn objSIgn = new SignIn();
                objSIgn.ShowDialog();
                objSIgn.Close();

                USER objUsers = new USER();
                objUsers = USER.Loading();
                if (MainWindow.SignedIN == true)
                {
                    //objUsers = USER.Loading();
                    this.buttonShoppingBag.IsEnabled = true;
                    this.buttonSignIn.Content = $"🤠{objUsers.Name}";

                }
                else
                {
                    this.buttonSignIn.Content = "SIGN IN";
                    this.buttonShoppingBag.IsEnabled = false;
                }
            }
            else if ((sender as Button).Name == "buttonShoppingBag")
            {
                ShoppingBag objShoppingBag = new ShoppingBag();
                objShoppingBag.ShowDialog();
                objShoppingBag.Close();
            }

            
            
            
            
        }

        
    }
}
