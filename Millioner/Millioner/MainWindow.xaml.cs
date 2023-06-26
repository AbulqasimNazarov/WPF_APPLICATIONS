using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
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

namespace Millioner;


public partial class MainWindow : Window, INotifyPropertyChanged
{
    
    public List<Button> buttons = new List<Button>();
    public event PropertyChangedEventHandler? PropertyChanged;

    public int questionNumber = 0;
    public delegate void deleqat(object sender, RoutedEventArgs e);
    public string FontSizeValue { get; set; } = "30";
    public MainWindow()
    {
        InitializeComponent();
        this.questionBox.Visibility = Visibility.Hidden;
        this.questionListBox.Visibility = Visibility.Hidden;
        this.buttons.AddRange(new[] {this.buttonA, this.buttonB, this.buttonC, this.buttonD});

        QuestionListBOX.addElementToListBox(ref this.questionListBox);

        
        this.DataContext = this;

    }

   
}
