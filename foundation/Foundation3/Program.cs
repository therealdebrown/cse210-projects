using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Create a list to store activities
        List<Activity> activities = new List<Activity>();

        // Add different activity objects
        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 4.8));
        activities.Add(new Cycling(new DateTime(2022, 11, 3), 45, 20.0));
        activities.Add(new Swimming(new DateTime(2022, 11, 3), 40, 20));

        // Loop through the list and display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
