public abstract class Activity
{
    protected string _date;
    protected int _length;

    protected string _name;
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }
    public string GetSummary()
    {
        return $"{_date} {_name} ({_length} min) - Distance {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.00} min per km";
    }
}