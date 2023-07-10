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
        public System.Windows.Media.ImageSource Icon { get; set; }
        public MainWindow()
        {
            InitializeComponent();

        }

        

        private void button_Click(object sender, RoutedEventArgs e)
        {
            CollectionWindow objWomen = new CollectionWindow();
            CollectionWindow objMen = new CollectionWindow("MEN");
            if ((sender as Button).Name == "buttonWomen")
            {
                Console.WriteLine("woman");
                objWomen.ShowDialog();
            }
            else if ((sender as Button).Name == "buttonMen")
            {

                objMen.ShowDialog();
            }
           
        }

        
    }
}
