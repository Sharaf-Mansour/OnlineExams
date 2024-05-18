namespace OnlineExams.Services.Foundation;
public partial interface IExamService
{
    bool AllowShowAnswer { get; set; }
    bool ShuffleAnswer { get; set; }
    bool ShuffleQeustion { get; set; }
    void SortQeustions();
    void SortAnswers();
    void ShuffleQeustions();
    void ShuffleAnswers();
    void AssignNumbers(int startNumber = 1);
}