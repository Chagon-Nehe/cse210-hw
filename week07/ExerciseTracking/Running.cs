public class Running : Activity
{
    private double _distanceKm;

    public Running(DateTime date, int minutes, double distanceKm) 
        // Call the base class constructor
        : base(date, minutes, "Running")
    {
        _distanceKm = distanceKm;
    }

    // Override methods to provide specific calculations
    
    public override double GetDistance()
    {
        // Distance is stored directly
        return _distanceKm;
    }

    // GetSpeed() and GetPace() do NOT need to be explicitly overridden here
    // because the base Activity class implementation uses GetDistance()
    // which is now overridden to return _distanceKm.
    // However, to make it explicit, we can re-implement the base logic:
    
    public override double GetSpeed()
    {
        // Speed (kph) = (distance / minutes) * 60
        if (_minutes == 0) return 0.0;
        return (GetDistance() / _minutes) * 60;
    }

    public override double GetPace()
    {
        // Pace (min per km) = minutes / distance
        if (GetDistance() == 0.0) return 0.0;
        return (double)_minutes / GetDistance();
    }
}