public class Running : Activity
{
    private float _distance;
    public Running(string date, int minutes, string name, float distance) : base(date, minutes, name)
    {
        _distance = distance;
    }
    public override float GetDistance()
    {
        return _distance;
    }
    public override float GetSpeed()
    {
        return (_distance / GetMinutes()) * 60;
    }
    public override float GetPace()
    {
        return 60 / GetSpeed();
    }
}