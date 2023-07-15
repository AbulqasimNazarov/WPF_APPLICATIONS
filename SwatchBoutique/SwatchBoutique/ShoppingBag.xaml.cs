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
        public ShoppingBag()
        {
            InitializeComponent();
            //this.comboBoxCount.def
            this.comboBoxCount.Items.Add("1");
            this.comboBoxCount.Items.Add("2");
            this.comboBoxCount.Items.Add("3");
        }

        public ShoppingBag(string name) : this()
        {

        }
    }
}
