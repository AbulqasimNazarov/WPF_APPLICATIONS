using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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
    private MediaPlayer mediaPlayer;
    public List<Button> buttons = new List<Button>();
    public event PropertyChangedEventHandler? PropertyChanged;

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

    public void ButtonStart_Click(object sender, RoutedEventArgs e)
    {
        this.questionBox.Visibility = Visibility.Visible;
        this.questionListBox.Visibility = Visibility.Visible;
        Button button = (Button)sender;
        this.Loqopic.Visibility = Visibility.Hidden;
        this.buttonStart.Visibility = Visibility.Hidden;
        string json = File.ReadAllText("question1.json");
        QuestionData answers1 = JsonSerializer.Deserialize<QuestionData>(json);


        this.questionBox.Text = answers1.Question;
        this.buttonA.Content += answers1.AnswerA;
        this.buttonB.Content += answers1.AnswerB;
        this.buttonC.Content += answers1.AnswerC;
        this.buttonD.Content += answers1.AnswerD;

        if (button.Name == "buttonA")
        {
            button.Background = new SolidColorBrush(Colors.Red);
        }

        this.questionListBox.IsEnabled= false;
        this.questionListBox.SelectedIndex=0;
        
    }


    public void answerButoon_click(object sender, RoutedEventArgs e)
    {
        Button b = (Button)sender;

        if (b.Name == "buttonA")
        {
            b.Background = new SolidColorBrush(Colors.Green);
        }
    }


}
