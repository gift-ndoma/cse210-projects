public class MotivationalQuote
{
    private List<string> _quotes = new List<string>
    {
        "Keep going, you're doing great!",
        "Every day is a fresh start.",
        "Small steps add up to big changes.",
        "Your journal is your safe space.",
        "Write what you feel, no judgment here.",
        "Reflect. Grow. Repeat."
    };

    private Random _random = new Random();

    public string GetRandomQuote()
    {
        int index = _random.Next(_quotes.Count);
        return _quotes[index];
    }
}
