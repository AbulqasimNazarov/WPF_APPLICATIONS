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
using static System.Net.Mime.MediaTypeNames;

namespace SwatchBoutique
{
    /// <summary>
    /// Interaction logic for CollectionWindow.xaml
    /// </summary>
    public partial class CollectionWindow : Window
    {
        public double WindowHeight { get; set; } = 577;
        public double WindowWidth { get; set; } = 583;

        public CollectionWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            this.womenPic2.Height = 180;
            this.womenPic3.Height = 180;
            
        }

        public CollectionWindow(string name)
        {
            InitializeComponent();
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

        
    }
}
