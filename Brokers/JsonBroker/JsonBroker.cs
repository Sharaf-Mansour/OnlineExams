namespace OnlineExams.Brokers.JsonBroker;
public partial class JsonBroker(HttpClient httpClient) : IJsonBroker
{
    public async ValueTask<Exam> ReadExamAsync(string url)
    {
        var jsonString = await  httpClient.GetStringAsync(url);
        return JsonSerializer.Deserialize<Exam>(jsonString) ?? new();
    }
}