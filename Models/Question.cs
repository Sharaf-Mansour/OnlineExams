namespace OnlineExams.Models;
public record Question(int ID, Answer[] Answers, string Value = "", ControlType Type = ControlType.RadioButton, bool IsCorrect = false, bool IsFlagged = false, int Num = 0)
{
    public bool IsCorrect { get; set; } = IsCorrect;
    public bool IsFlagged { get; set; } = IsFlagged;
    public Answer[] Answers { get; set; } = Answers;
    public int Num { get; set; } = Num;
}