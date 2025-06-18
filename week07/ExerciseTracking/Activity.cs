public abstract class Activity
{
    private int _minutes;
    private string _date;
    private string _name;

    public Activity(string date, int minutes, string name)
    {
        _date = date;
        _minutes = minutes;
        _name = name;
    }

    public string GetDate()
    {
        return _date;
    }
    public string GetName()
    {
        return _name;
    }
    public abstract float GetDistance(); 
    public abstract float GetSpeed();   
    public abstract float GetPace();
    public int GetMinutes() => _minutes;

    public virtual string GetSummary()
    {
         return $"{_date} {_name} ({_minutes} min): Distance {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.00} min per km";
    }
}