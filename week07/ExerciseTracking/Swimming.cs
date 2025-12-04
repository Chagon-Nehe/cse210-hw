public class Swimming : Activity
{
    private int _laps;
    private const double LapLengthMeters = 50.0; // 50 meters per lap
    private const double MetersPerKm = 1000.0;

    public Swimming(DateTime date, int minutes, int laps) 
        : base(date, minutes, "Swimming")
    {
        _laps = laps;
    }

    // Override methods to provide specific calculations
    
    public override double GetDistance()
    {
        // Distance (km) = (laps * 50) / 1000
        // Distance (km) = (laps * LapLengthMeters) / MetersPerKm
        double totalMeters = _laps * LapLengthMeters;
        return totalMeters / MetersPerKm;
    }

    public override double GetSpeed()
    {
        // Speed (kph) = (distance / minutes) * 60
        // Uses the overridden GetDistance()
        double distance = GetDistance();
        if (_minutes == 0) return 0.0;
        return (distance / _minutes) * 60;
    }

    public override double GetPace()
    {
        // Pace (min per km) = minutes / distance
        // Uses the overridden GetDistance()
        double distance = GetDistance();
        if (distance == 0.0) return 0.0;
        return (double)_minutes / distance;
    }
}