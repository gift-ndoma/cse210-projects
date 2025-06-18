public class Cycling : Activity
{
    private float _speed;
    public Cycling(string date, int minutes, string name, float speed) : base(date, minutes, name)
    {
        _speed = speed;
    }
    public override float GetDistance()
    {
        return (_speed * GetMinutes()) / 60;
    }
    public override float GetPace()
    {
        return 60 / _speed;
    }
    public override float GetSpeed()
    {
        return _speed;
    }
}