using System;
using System.Globalization;

public class Activity
{
    // Private member variables (Encapsulation)
    private DateTime _date;
    protected int _minutes;
    private string _activityType;

    // Constructor
    public Activity(DateTime date, int minutes, string activityType)
    {
        _date = date;
        _minutes = minutes;
        _activityType = activityType;
    }

    // --- Polymorphic Methods (Calculation) ---
    
    // Virtual method to get the distance (to be overridden)
    public virtual double GetDistance()
    {
        // Base implementation returns 0.0, will be properly calculated in derived classes.
        return 0.0;
    }

    // Virtual method to get the speed in kph (to be overridden)
    public virtual double GetSpeed()
    {
        // Speed (kph) = (distance / minutes) * 60
        // Since GetDistance() is 0.0 here, this will also return 0.0.
        // Derived classes will call their overridden GetDistance().
        if (_minutes == 0) return 0.0;
        return (GetDistance() / _minutes) * 60;
    }

    // Virtual method to get the pace in min per km (to be overridden)
    public virtual double GetPace()
    {
        // Pace (min per km) = minutes / distance
        if (GetDistance() == 0.0) return 0.0;
        return (double)_minutes / GetDistance();
    }

    // --- Concrete Method (Summary) ---
    
    // Method to return the summary string (available to all derived classes)
    public string GetSummary()
    {
        // Format the date as "dd MMM yyyy"
        string dateFormatted = _date.ToString("dd MMM yyyy", CultureInfo.InvariantCulture);

        // Get calculated values
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        // Use string interpolation to build the summary
        return $"{dateFormatted} {_activityType} ({_minutes} min): " +
               $"Distance {distance:F2} km, Speed: {speed:F2} kph, Pace: {pace:F2} min per km";
    }
}