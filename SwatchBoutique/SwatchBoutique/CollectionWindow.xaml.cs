using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using static System.Net.Mime.MediaTypeNames;
using Image = System.Windows.Controls.Image;

namespace SwatchBoutique
{
    /// <summary>
    /// Interaction logic for CollectionWindow.xaml
    /// </summary>
    public partial class CollectionWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public double WindowHeight { get; set; } = 577;
        public double WindowWidth { get; set; } = 583;

        public BitmapImage forBinding { get; set; } = new BitmapImage();

        public List<Button> buttonBuyList { get; set; } = new List<Button>();
        public Image BindingForImage { get; set; } = new Image();

        public List<Image> imageBuyList { get; set; } = new List<Image>();

        List<string> infotextList { get; set; } = new List<string>();
        List<string> priceList { get; set; } = new List<string>();

        public CollectionWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            this.womenPic2.Height = 180;
            this.womenPic3.Height = 180;
            this.buttonBuyList.Add(this.buttonBuy1);
            this.buttonBuyList.Add(this.buttonBuy2);
            this.buttonBuyList.Add(this.buttonBuy3);
            this.imageBuyList.Add(this.womenPic1);
            this.imageBuyList.Add(this.womenPic2);
            this.imageBuyList.Add(this.womenPic3);
            this.infotextList.Add(this.Info1.Text);
            this.infotextList.Add(this.Info2.Text);
            this.infotextList.Add(this.info3.Text);
            this.priceList.Add(this.price1.Text);
            this.priceList.Add(this.price2.Text);
            this.priceList.Add(this.price3.Text);

            
        }

        public CollectionWindow(string name) :this()
        {
            //InitializeComponent();
            this.DataContext = this;
            this.nameOfThePage.Content = name;

            var bitmapImage1 = new BitmapImage();
            var bitmapImage2 = new BitmapImage();
            var bitmapImage3 = new BitmapImage();
                                  
            // LINQ
            this.womenPic1.Source = bitmapImage1.ChangePic("Assets/men1.png");
            this.womenPic2.Source = bitmapImage2.ChangePic("Assets/men2 - Copy.png");
            this.womenPic3.Source = bitmapImage3.ChangePic("Assets/men3 - Copy.png");

            this.Info1.Text = "Men Pre-Owned Rolex Watches";
            this.Info2.Text = "Men Pre-Owned Rolex Watches";
            this.info3.Text = "Men Pre-Owned Rolex Watches";

            this.price1.Text = "7.000,00";
            this.price2.Text = "12.000,00";
            this.price3.Text = "8.000,00";           
            
        }

        

        private void buttonBuy3_Click(object sender, RoutedEventArgs e)
        {

            ProduktClass product = new ProduktClass();
            string condition = (sender as Button).Name;
            if (MainWindow.SignedIN == true)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (condition == this.buttonBuyList[i].Name)
                    {
                        product = new ProduktClass(this.imageBuyList[i].Source.ToString(), this.infotextList[i], this.priceList[i]);
                    }
                }

                foreach (var item in this.buttonBuyList)
                {
                    item.IsEnabled = false;
                    item.Background = Brushes.Red;
                }
                product.SaveProduct(product);
            }
            else
            {
                MessageBox.Show("For buying sign in");
            }
        }
    }
}
