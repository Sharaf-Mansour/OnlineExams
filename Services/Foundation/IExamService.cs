namespace OnlineExams.Services.Foundation;
public partial interface IExamService
{
    Exam Exam { get; }
    ValueTask<Exam> RetrieveExamAsync(ExamCode type);
    int RetrieveFlagCount();
    double RetrieveScore();
    int RetrieveQeustionsCount();
    double RetrieveAnsweredCount();
    int RetrieveNotAnsweredCount();
    string RetrieveGrade();
}