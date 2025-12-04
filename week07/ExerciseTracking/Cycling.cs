public class Cycling : Activity
{
    private double _speedKph;

    public Cycling(DateTime date, int minutes, double speedKph) 
        : base(date, minutes, "Cycling")
    {
        _speedKph = speedKph;
    }

    // Override methods to provide specific calculations
    
    public override double GetDistance()
    {
        // Distance (km) = (speed * minutes) / 60
        // Distance = (kph * minutes) / 60
        return _speedKph * _minutes / 60;
    }

    public override double GetSpeed()
    {
        // Speed is stored directly
        return _speedKph;
    }

    public override double GetPace()
    {
        // Pace (min per km) = 60 / speed
        if (_speedKph == 0) return 0.0;
        return 60 / _speedKph;
    }
}