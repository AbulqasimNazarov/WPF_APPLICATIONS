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
        public System.Windows.Media.ImageSource Icon { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            this.buttonShoppingBag.IsEnabled = false;
            //this.WINDOW1.Height = 200;
        }

        

        private void button_Click(object sender, RoutedEventArgs e)
        {

            CollectionWindow objWomen = new CollectionWindow();
            CollectionWindow objMen = new CollectionWindow("MEN");
            SignIn objSIgn = new SignIn();
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
            }
            objMen.Close();
            objWomen.Close();
            objSIgn.Close();
        }

        
    }
}
