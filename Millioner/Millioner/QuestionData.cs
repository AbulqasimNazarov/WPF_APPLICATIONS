

using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Millioner;

public class QuestionData
{
    public List<string>? questionList = new List<string>();
    //public List<string> answerList = new List<string>();

    public string? Question { get; set; }
    public string? AnswerA { get; set; }
    public string? AnswerB { get; set; }
    public string? AnswerC { get; set; }
    public string? AnswerD { get; set; }

    public QuestionData()
    {

    }

    public static QuestionData? LoadQuestion(string path)
    {
        string json = File.ReadAllText(path);
        return JsonSerializer.Deserialize<QuestionData>(json);
    }
    
}
