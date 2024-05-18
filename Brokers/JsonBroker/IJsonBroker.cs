namespace OnlineExams.Brokers.JsonBroker;
public partial interface IJsonBroker
{
    ValueTask<Exam> ReadExamAsync(string url);
}