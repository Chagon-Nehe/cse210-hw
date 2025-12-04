using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Exercise Tracking Program ---");
        Console.WriteLine("Demonstrating Inheritance and Polymorphism\n");

        // 1. Create at least one activity of each type
        Running run = new Running(
            date: new DateTime(2025, 12, 11),
            minutes: 30,
            distanceKm: 4.8);

        Cycling cycle = new Cycling(
            date: new DateTime(2025, 12, 11),
            minutes: 45,
            speedKph: 25.0); // KPH

        Swimming swim = new Swimming(
            date: new DateTime(2025, 12, 12),
            minutes: 35,
            laps: 40); // 40 laps * 50m = 2000m = 2.0 km

        // 2. Put each of these activities in the same list (Polymorphism/Upcasting)
        List<Activity> activities = new List<Activity>
        {
            run,
            cycle,
            swim,
            // You can add more activities of any derived type
            new Running(new DateTime(2025, 12, 10), 60, 10.0),
            new Cycling(new DateTime(2025, 12, 10), 90, 30.5)
        };

        // 3. Iterate through this list and call the GetSummary method on each item
        Console.WriteLine("--- Activity Summaries ---");
        foreach (Activity a in activities)
        {
            // The correct GetDistance/GetSpeed/GetPace (Overridden methods) 
            // are called from within GetSummary() based on the actual object type.
            Console.WriteLine(a.GetSummary());
        }
    }
}

// NOTE: For a single C# file environment (like many online editors or course sandboxes), 
// you would place all the class definitions (Activity, Running, Cycling, Swimming) 
// and the Program class in the same file.