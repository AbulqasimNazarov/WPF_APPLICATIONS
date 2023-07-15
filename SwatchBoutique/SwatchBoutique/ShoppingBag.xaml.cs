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
    /// Interaction logic for ShoppingBag.xaml
    /// </summary>
    public partial class ShoppingBag : Window
    {
        public ProduktClass obj = new ProduktClass();

        public int totalProp { get; set; } = new int();
        public ShoppingBag()
        {
            InitializeComponent();
            if (MainWindow.Boughted == true)
            {
                this.buttonPay.IsEnabled = false;
                this.buttonPay.Background = Brushes.Red;
            }

            obj = ProduktClass.LoadProduct();

            

            BitmapImage bitmapImage = new BitmapImage();
            if (obj?.Path != null)
            {
                this.INFO.Text = obj.Info;
                this.imageShoppingBag.Source = new BitmapImage(new Uri(obj.Path));
                this.textBoxTotal.Text = obj.Price;
            }
            else
            {
                MessageBox.Show("EMPTY!!!");
                return;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("We will contact you by email as soon. Thank you for choice!");
            MainWindow.Boughted = true;
            this.Close();
        }
    }
}
