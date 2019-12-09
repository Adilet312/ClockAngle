using System;

class ClockAngle 
{
    static void Main()
    {
        Console.WriteLine("Enter time in 00:00 format: ");
        string timeInput = Console.ReadLine();
        Clock currentClock = new Clock(timeInput);
        Console.WriteLine("The distance in degrees between the minute and hour hands: " + currentClock.getAngle().ToString() + "°");
    }
}

public class Clock{
    public int hours;
    public int minutes;
    public Clock(string time) 
    {
        if (time.Length == 5) {
            hours = int.Parse(time.Substring(0,2));
            minutes = int.Parse(time.Substring(3));
        } else {
            hours = int.Parse(time.Substring(0,1));
            minutes = int.Parse(time.Substring(2));
        }
        
    }

    public int getAngle() 
    {
        if (Math.Abs(minutes - hours * 5) == 30) {
            return 180;
        }
        return (Math.Abs(minutes - hours * 5) % 30) * 6;
    }
}