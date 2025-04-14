public class Swimming : Activity
{
    private double _numberOfLaps;
    public Swimming(string date, int length, int numberOfLaps) : base(date, length)
    {
        _numberOfLaps = numberOfLaps;
        _name = "Swimming";
    }
    public override double GetDistance()
    {
        return _numberOfLaps * 50 / 1000;
    }

    public override double GetPace()
    {
        return _length / GetDistance();
    }

    public override double GetSpeed()
    {
        return GetDistance() / _length * 60;
    }
}