using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Swimming swimming = new Swimming("03 Nov 2022", 30, "Swimming", 10);
        Running running = new Running("04 Nov 2023", 35, "Running", 40);
        Cycling cycling = new Cycling("05 Nov 2025", 40, "Cycling", 40);

        activities.Add(cycling);
        activities.Add(running);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            string summary = activity.GetSummary();
            Console.WriteLine(summary);
        }
    }
}