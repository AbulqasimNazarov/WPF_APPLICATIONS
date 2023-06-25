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
    private MediaPlayer mediaPlayer;
    public List<Button> buttons = new List<Button>();
    public event PropertyChangedEventHandler? PropertyChanged;

    public int questionNumber = 0;

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
        this.buttonAgainStart.Visibility = Visibility.Hidden;

        QuestionData? answers1 = QuestionData.LoadQuestion("question1.json");

        foreach (var item in this.buttons)
        {
            item.Visibility = Visibility.Visible;
        }

        if (answers1 != null)
        {
            
            this.questionBox.Text = answers1.Question;
            this.buttonA.Content += answers1.AnswerA;
            this.buttonB.Content += answers1.AnswerB;
            this.buttonC.Content += answers1.AnswerC;
            this.buttonD.Content += answers1.AnswerD;
            this.questionNumber = 1;
        }
        else
            MessageBox.Show("ERROR");

        this.questionListBox.IsEnabled= true;
        this.questionListBox.SelectedIndex=0;
        
        
    }


    public void questionFirstButoon_click(object sender, RoutedEventArgs e)
    {
        //Button b = (Button)sender;
        //QuestionData? answers1 = QuestionData.LoadQuestion("question1.json");
        //QuestionData? answers2 = QuestionData.LoadQuestion("question2.json");
        //QuestionData? answers3 = QuestionData.LoadQuestion("question3.json");
        //QuestionData? answers4 = QuestionData.LoadQuestion("question4.json");
        //QuestionData? answers5 = QuestionData.LoadQuestion("question5.json");

        //if (this.questionBox.Text == answers1?.Question)
        //{
        //    if (b.Name != "buttonA")
        //    {
        //        b.Background = new SolidColorBrush(Colors.Red);
        //        this.questionBox.Visibility = Visibility.Hidden;
        //        this.LOSEPIC.Visibility = Visibility.Visible;
        //        this.CryPic.Visibility = Visibility.Visible;
        //        foreach (var item in this.buttons)
        //        {
        //            item.Visibility = Visibility.Hidden;
        //        }
        //        this.buttonAgainStart.Visibility = Visibility.Visible;

        //        this.questionListBox.Visibility = Visibility.Hidden;
        //    }

        //    else
        //    {
        //        b.Background = new SolidColorBrush(Colors.Green);
        //        if (answers2 != null)
        //        {
        //            b.Background = new SolidColorBrush(Colors.FloralWhite);
        //            this.questionBox.Text = answers2.Question;
        //            this.buttonA.Content = $"A: {answers2.AnswerA}";
        //            this.buttonB.Content = $"B: {answers2.AnswerB}";
        //            this.buttonC.Content = $"C: {answers2.AnswerC}";
        //            this.buttonD.Content = $"D: {answers2.AnswerD}";
        //            this.questionListBox.SelectedIndex = 1;

        //        }
        //        else
        //            MessageBox.Show("ERROR");

        //        if (b.Name == "buttonC")
        //        {
        //            b.Background = new SolidColorBrush(Colors.FloralWhite);
        //            this.questionBox.Text = answers3.Question;
        //            this.buttonA.Content = $"A: {answers3.AnswerA}";
        //            this.buttonB.Content = $"B: {answers3.AnswerB}";
        //            this.buttonC.Content = $"C: {answers3.AnswerC}";
        //            this.buttonD.Content = $"D: {answers3.AnswerD}";
        //            this.questionListBox.SelectedIndex = 2;
        //        }
        //    }
        //}







    }

    private void buttonAnswer_Click(object sender, RoutedEventArgs e)
    {

        QuestionData? answers1 = QuestionData.LoadQuestion("question1.json");
        QuestionData? answers2 = QuestionData.LoadQuestion("question2.json");
        QuestionData? answers3 = QuestionData.LoadQuestion("question3.json");
        QuestionData? answers4 = QuestionData.LoadQuestion("question4.json");
        QuestionData? answers5 = QuestionData.LoadQuestion("question5.json");
        Button b = (Button)sender;
        switch (this.questionNumber)
        {
            case 1:
                if (b.Name == "buttonA")
                {
                    b.Background = new SolidColorBrush(Colors.Green);
                    if (answers2 != null)
                    {
                        b.Background = new SolidColorBrush(Colors.FloralWhite);
                        this.questionBox.Text = answers2.Question;
                        this.buttonA.Content = $"A: {answers2.AnswerA}";
                        this.buttonB.Content = $"B: {answers2.AnswerB}";
                        this.buttonC.Content = $"C: {answers2.AnswerC}";
                        this.buttonD.Content = $"D: {answers2.AnswerD}";
                        this.questionListBox.SelectedIndex = 1;
                        this.questionNumber = 2;

                    }
                    else
                        MessageBox.Show("ERROR");
                }
                else
                {
                    b.Background = new SolidColorBrush(Colors.Red);
                    this.questionBox.Visibility = Visibility.Hidden;
                    this.LOSEPIC.Visibility = Visibility.Visible;
                    
                    foreach (var item in this.buttons)
                    {
                        item.Visibility = Visibility.Hidden;
                    }
                    this.buttonAgainStart.Visibility = Visibility.Visible;

                    this.questionListBox.Visibility = Visibility.Hidden;
                }
                break;
            case 2:
                if (b.Name == "buttonC")
                {
                    b.Background = new SolidColorBrush(Colors.Green);
                    if (answers2 != null)
                    {
                        b.Background = new SolidColorBrush(Colors.FloralWhite);
                        this.questionBox.Text = answers3?.Question;
                        this.buttonA.Content = $"A: {answers3?.AnswerA}";
                        this.buttonB.Content = $"B: {answers3?.AnswerB}";
                        this.buttonC.Content = $"C: {answers3?.AnswerC}";
                        this.buttonD.Content = $"D: {answers3?.AnswerD}";
                        this.questionListBox.SelectedIndex = 2;
                        this.questionNumber = 3;

                    }
                    else
                        MessageBox.Show("ERROR");
                }
                else
                {
                    b.Background = new SolidColorBrush(Colors.Red);
                    this.questionBox.Visibility = Visibility.Hidden;
                    this.LOSEPIC.Visibility = Visibility.Visible;
                    
                    foreach (var item in this.buttons)
                    {
                        item.Visibility = Visibility.Hidden;
                    }
                    this.buttonAgainStart.Visibility = Visibility.Visible;

                    this.questionListBox.Visibility = Visibility.Hidden;
                }
                break;
            case 3:
                if (b.Name == "buttonA")
                {
                    b.Background = new SolidColorBrush(Colors.Green);
                    if (answers2 != null)
                    {
                        b.Background = new SolidColorBrush(Colors.FloralWhite);
                        this.questionBox.Text = answers4?.Question;
                        this.buttonA.Content = $"A: {answers4?.AnswerA}";
                        this.buttonB.Content = $"B: {answers4?.AnswerB}";
                        this.buttonC.Content = $"C: {answers4?.AnswerC}";
                        this.buttonD.Content = $"D: {answers4?.AnswerD}";
                        this.questionListBox.SelectedIndex = 3;
                        this.questionNumber = 4;

                    }
                    else
                        MessageBox.Show("ERROR");
                }
                else
                {
                    b.Background = new SolidColorBrush(Colors.Red);
                    this.questionBox.Visibility = Visibility.Hidden;
                    this.LOSEPIC.Visibility = Visibility.Visible;

                    foreach (var item in this.buttons)
                    {
                        item.Visibility = Visibility.Hidden;
                    }
                    this.buttonAgainStart.Visibility = Visibility.Visible;

                    this.questionListBox.Visibility = Visibility.Hidden;
                }
                break;
            case 4:
                if (b.Name == "buttonD")
                {
                    b.Background = new SolidColorBrush(Colors.Green);
                    if (answers2 != null)
                    {
                        b.Background = new SolidColorBrush(Colors.FloralWhite);
                        this.questionBox.Text = answers5?.Question;
                        this.buttonA.Content = $"A: {answers5?.AnswerA}";
                        this.buttonB.Content = $"B: {answers5?.AnswerB}";
                        this.buttonC.Content = $"C: {answers5?.AnswerC}";
                        this.buttonD.Content = $"D: {answers5?.AnswerD}";
                        this.questionListBox.SelectedIndex = 4;
                        this.questionNumber = 5;

                    }
                    else
                        MessageBox.Show("ERROR");
                }
                else
                {
                    b.Background = new SolidColorBrush(Colors.Red);
                    this.questionBox.Visibility = Visibility.Hidden;
                    this.LOSEPIC.Visibility = Visibility.Visible;

                    foreach (var item in this.buttons)
                    {
                        item.Visibility = Visibility.Hidden;
                    }
                    this.buttonAgainStart.Visibility = Visibility.Visible;

                    this.questionListBox.Visibility = Visibility.Hidden;
                }
                break;
            case 5:
                if (b.Name == "buttonC")
                {
                    
                }
                else
                {
                    b.Background = new SolidColorBrush(Colors.Red);
                    this.questionBox.Visibility = Visibility.Hidden;
                    this.LOSEPIC.Visibility = Visibility.Visible;

                    foreach (var item in this.buttons)
                    {
                        item.Visibility = Visibility.Hidden;
                    }
                    this.buttonAgainStart.Visibility = Visibility.Visible;

                    this.questionListBox.Visibility = Visibility.Hidden;
                }
                break;

            default:
                break;
        }

    }
}
