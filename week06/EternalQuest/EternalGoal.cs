public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }
    public override int RecordEvent()
    {
        int point = GetPoints();
        Console.WriteLine($"You earned {point} points!");
        return point;
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal: {GetName()}, {GetDescription()}, {GetPoints()}";
    }
}