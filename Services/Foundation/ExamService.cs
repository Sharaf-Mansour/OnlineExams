namespace OnlineExams.Services.Foundation;
public partial class ExamService(IJsonBroker jsonBroker) : IExamService
{
    public Exam Exam { get; private set; } = new();
    public async ValueTask<Exam> RetrieveExamAsync(ExamCode type) => Exam = type switch
    {
        ExamCode.MTA98_361 => await jsonBroker.ReadExamAsync("MTA-98-361.json"),
        ExamCode.AI900 or _ => await jsonBroker.ReadExamAsync("AI-900.json"),
    };
    public int RetrieveFlagCount() => Exam.Questions.Count(x => x.IsFlagged);
    public double RetrieveScore() => Exam.Questions.Count(x => x.IsCorrect);
    public int RetrieveQeustionsCount() => Exam.Questions.Length;
    public double RetrieveAnsweredCount() => Exam.Questions.Count(x => x.Answers.Any(i => i.IsSelected));
    public int RetrieveNotAnsweredCount() => Exam.Questions.Count(x => !x.Answers.Any(i => i.IsSelected));
    public string RetrieveGrade() => (RetrieveScore() / RetrieveQeustionsCount() * 100).ToString("0.##") + "%";
}