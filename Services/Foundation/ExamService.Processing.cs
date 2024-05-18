namespace OnlineExams.Services.Foundation;
public partial class ExamService : IExamService
{
    public bool AllowShowAnswer { get; set; }
    public bool ShuffleAnswer { get; set; }
    public bool ShuffleQeustion { get; set; }
    public void SortQeustions() => Exam.Questions = [.. Exam.Questions.OrderBy(x => x.ID)];
    public void SortAnswers()
    {
        for (int i = 0; i < RetrieveQeustionsCount(); i++)
            Exam.Questions[i].Answers = [.. Exam.Questions[i].Answers.OrderBy(x => x.ID)];
    }
    public void ShuffleQeustions() => Exam.Questions.Shuffle();
    public void ShuffleAnswers()
    {
        for (int i = 0; i < RetrieveQeustionsCount(); i++)
            Exam.Questions[i].Answers.Shuffle();
    }
    public void AssignNumbers(int startNumber = 1)
    {
        for (int i = 0; i < RetrieveQeustionsCount(); i++)
             Exam.Questions[i].Num = startNumber++;
    }
}