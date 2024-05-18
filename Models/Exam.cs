namespace OnlineExams.Models;
public class Exam
{
    public string? ExamCode { get; set; }
    public Question[] Questions { get; set; } = [];
}