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
    /// Interaction logic for SignIn.xaml
    /// </summary>
    public partial class SignIn : Window
    {
        public SignIn()
        {
            InitializeComponent();
            
            
        }

        private void CHECKING(object sender, RoutedEventArgs e)
        {
            var bitmapImage4 = new BitmapImage();

            if (this.ShowPasswordCHekcBox.IsChecked == true)
            {
                this.EMOJI.Source = bitmapImage4.ChangePic("Assets/emoji1.png");
            }
            else
                this.EMOJI.Source = bitmapImage4.ChangePic("Assets/emoji2.jpg");
        }
    }
}
