using System;
using System.Collections.Generic;
using System.IO;
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
        public ProduktClass obj { get; set; } = new ProduktClass();
        
        public BitmapImage bindIMAGE { get; set; } = new BitmapImage();
        public int totalProp { get; set; } = new int();
        public ShoppingBag()
        {
            InitializeComponent();
            this.DataContext = this;
            if (MainWindow.Boughted == true)
            {
                this.buttonPay.IsEnabled = false;
                this.buttonPay.Background = Brushes.Red;
            }


            obj = ProduktClass.LoadProduct();


            if (obj != null)
            {
                this.INFO.Text = obj.Info;
                this.bindIMAGE.BeginInit();
                this.bindIMAGE.UriSource = new Uri(obj.Path, UriKind.RelativeOrAbsolute);
                this.bindIMAGE.EndInit();
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
