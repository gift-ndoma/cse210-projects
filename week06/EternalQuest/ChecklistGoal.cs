public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    public ChecklistGoal(string name, string description, int points, int target, int bonus, int completed) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = completed;
    }
    public override int RecordEvent()
    {
        _amountCompleted++;
        int earned = GetPoints();
        if (_amountCompleted == _target)
        {
            earned += _bonus;
            Console.WriteLine("Goal Completed! You just earned a bonus.");
        }
        Console.WriteLine($"You earned {earned} points!");
        return earned;
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {GetName()} ({GetDescription()}) -- Currently Completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal: {GetName()}, {GetDescription()}, {GetPoints()}, {_target}, {_bonus}, {_amountCompleted}";
    }
      public int GetBonus()
    {
        return _bonus;
    }

    public int GetCompleted()
    {
        return _amountCompleted;
    }

    public int GetTarget()
    {
        return _target;
    }
}