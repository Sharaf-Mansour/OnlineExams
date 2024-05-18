namespace OnlineExams.Pages;
public partial class Questions
{
    [Parameter] public int QNumber { get; set; } = 1;
    private Question Question => ExamService.Exam.Questions[QNumber - 1 % (ExamService.RetrieveQeustionsCount() + 1)];
    private bool IsAnswered { get; set; }
    private bool CorrectAnswer { get; set; }
    protected override void OnInitialized()
    {

        if (QNumber < 1 || QNumber > ExamService.RetrieveQeustionsCount())
            NavigationManager.NavigateTo("/", true);
    }
    private void RadioSelection(Answer Answer)
    {
        Question.ResetSelection();
        (Answer.IsSelected, IsAnswered) = (true, true);
        Question.IsCorrect = CorrectAnswer = Answer.IsCorrect;
    }
    private void CheckSelection(Answer answer)
    {
        (CorrectAnswer, IsAnswered) = (false, true);
        Question.Answers.First(x => x.ID == answer.ID).IsSelected = answer.IsSelected;
        var CorrectAnswersCount = Question.Answers.Count(x => x.IsCorrect);
        var SelectsAnswers = Question.Answers.Where(x => x.IsSelected);
        Question.IsCorrect = CorrectAnswer = SelectsAnswers.All(x => x.IsCorrect) && SelectsAnswers.Count() == CorrectAnswersCount;
    }
    private void NavigateToComponent(string Page)
    {
        (IsAnswered, CorrectAnswer) = (false, false);
        NavigationManager.NavigateTo($"Q/{Page}");
    }
}