
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Millioner;

public partial class MainWindow
{
    
    public void ELSE()
    {
        
        this.questionBox.Visibility = Visibility.Hidden;
        this.LOSEPIC.Visibility = Visibility.Visible;

        foreach (var item in this.buttons)
        {
            item.Visibility = Visibility.Hidden;
        }
        this.buttonAgainStart.Visibility = Visibility.Visible;

        this.questionListBox.Visibility = Visibility.Hidden;
    }


    public void ButtonStart_Click(object sender, RoutedEventArgs e)
    {
        this.questionBox.Visibility = Visibility.Visible;
        this.questionListBox.Visibility = Visibility.Visible;

        Button button = (Button)sender;
        this.Loqopic.Visibility = Visibility.Hidden;
        this.buttonStart.Visibility = Visibility.Hidden;
        this.buttonAgainStart.Visibility = Visibility.Hidden;

        QuestionData answers1 = new QuestionData("question1.json");

        foreach (var item in this.buttons)
        {
            item.Visibility = Visibility.Visible;
        }

        if (answers1 != null)
        {
            answers1.Otrabotka(this.questionBox, this.buttons);
            this.questionNumber = 1;
        }
        else
            MessageBox.Show("ERROR");

        this.questionListBox.IsEnabled = true;
        this.questionListBox.SelectedIndex = 0;


    }


    private void buttonAgainStart_Click(object sender, RoutedEventArgs e)
    {
        this.buttonAgainStart.Visibility = Visibility.Hidden;
        this.LOSEPIC.Visibility = Visibility.Hidden;
        this.FinishPic.Visibility = Visibility.Hidden;
        deleqat del = ButtonStart_Click;
        del(sender, e);
    }

    private void buttonAnswer_Click(object sender, RoutedEventArgs e)
    {

        QuestionData? answers2 = new QuestionData("question2.json");
        QuestionData? answers3 = new QuestionData("question3.json");
        QuestionData? answers4 = new QuestionData("question4.json");
        QuestionData? answers5 = new QuestionData("question5.json");
        Button b = (Button)sender;  
        switch (this.questionNumber)
        {
            case 1:
                if (b.Name == "buttonA")
                {
                   
                    if (answers2 != null)
                    {
                        answers2.Otrabotka(this.questionBox, this.buttons);
                        this.questionListBox.SelectedIndex = 1;
                        this.questionNumber = 2;
                    }
                    else
                        MessageBox.Show("ERROR");
                }
                else
                {
                    ELSE();
                }
                break;
            case 2:
                if (b.Name == "buttonC")
                {
                if (answers2 != null)
                    {                      
                        answers3.Otrabotka(this.questionBox, this.buttons);
                        this.questionListBox.SelectedIndex = 2;
                        this.questionNumber = 3;
                    }
                    else
                        MessageBox.Show("ERROR");
                }
                else
                {
                    ELSE();
                }
                break;
            case 3:
                if (b.Name == "buttonA")
                {
                    if (answers4 != null)
                    {
                        answers4.Otrabotka(this.questionBox, this.buttons);
                        this.questionListBox.SelectedIndex = 3;
                        this.questionNumber = 4;
                    }
                    else
                        MessageBox.Show("ERROR");
                }
                else
                {
                    ELSE();
                }
                break;
            case 4:
                if (b.Name == "buttonD")
                {
                    if (answers5 != null)
                    { 
                        answers5.Otrabotka(this.questionBox, this.buttons);
                        this.questionListBox.SelectedIndex = 4;
                        this.questionNumber = 5;
                    }
                    else
                        MessageBox.Show("ERROR");
                }
                else
                {
                    ELSE();
                }
                break;
            case 5:
                if (b.Name == "buttonC")
                {
                    ELSE();
                    this.LOSEPIC.Visibility = Visibility.Hidden;
                    //this.buttonAgainStart.Visibility = Visibility.Hidden;
                    this.FinishPic.Visibility = Visibility.Visible;

                }
                else
                {
                    ELSE();
                }
                break;

            default:
                break;
        }

    }
}
