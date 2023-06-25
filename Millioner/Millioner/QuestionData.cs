

using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Millioner;

public class QuestionData
{
    public List<string> questionList = new List<string>();
    //public List<string> answerList = new List<string>();
    QuestionData? a;
    public string? Question { get; set; }
    public string? AnswerA { get; set; }
    public string? AnswerB { get; set; }
    public string? AnswerC { get; set; }
    public string? AnswerD { get; set; }

    public QuestionData()
    {

    }
    public QuestionData(string path)
    {
        string json = File.ReadAllText(path);
        this.a = JsonSerializer.Deserialize<QuestionData>(json);
        this.questionList.Add(a.AnswerA);
        this.questionList.Add(a.AnswerB);
        this.questionList.Add(a.AnswerC);
        this.questionList.Add(a.AnswerD);
    }

    public void Otrabotka(TextBox Text, List<Button> buttonList)
    {
        Text.Text = a?.Question;
        buttonList[0].Content = $"A: {a?.AnswerA}";
        buttonList[1].Content = $"B: {a?.AnswerB}";
        buttonList[2].Content = $"C: {a?.AnswerC}";
        buttonList[3].Content = $"D: {a?.AnswerD}";
    }


}
