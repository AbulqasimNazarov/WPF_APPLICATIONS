

using System.Collections.Generic;
using System.IO;

namespace Millioner;

public class QuestionData
{
    public List<string> questionList = new List<string>();
    public List<string> answerList = new List<string>();

    public string Question { get; set; }
    public string AnswerA { get; set; }
    public string AnswerB { get; set; }
    public string AnswerC { get; set; }
    public string AnswerD { get; set; }

    public QuestionData()
    {
        //this.questionList.Add(File.ReadAllText("quest.txt"));
        //this.Question =
        this.answerList.Add(AnswerA);
        this.answerList.Add(AnswerB);
        this.answerList.Add(AnswerC);

        this.answerList.Add(AnswerD);

    }
    
}
