namespace OnlineExams.Extensions;
public static class Helpercs
{
    private static Random Random => new((int)DateTime.Now.Ticks);
    public static void Shuffle<T>(this T[] list) 
    {
        int n = list.Length;
        while (n > 1)
        {
            int k = Random.Next(n--);
            (list[k], list[n]) = (list[n], list[k]);
        }
    }
    public static void ResetSelection(this Question question)
    {
        for (int i = 0; i < question.Answers.Length; i++)
            question.Answers[i].IsSelected = false;
    }

}
