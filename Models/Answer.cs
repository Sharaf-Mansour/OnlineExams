namespace OnlineExams.Models;
public record Answer(int ID, string Value, bool IsCorrect = false, bool IsSelected = false) 
{
    public bool IsSelected { get; set; } = IsSelected; 
}