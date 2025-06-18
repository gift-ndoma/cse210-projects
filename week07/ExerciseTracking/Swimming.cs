public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, string name, int laps) : base(date, minutes, name)
    {
        _laps = laps;
    }
    public override float GetDistance()
    {
        return _laps * 50f / 1000f;
    }
    public override float GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }
    public override float GetPace()
    {
        return 60 / GetSpeed();
    }
}