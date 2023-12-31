﻿namespace Exercise_2;

public class Taxi
{
    private int id; 
    
    public Taxi(TrafficLight tl, int id)
    {
        this.id = id;
        tl.OnLightChange += ReactToLight;
    }
    
    private void ReactToLight(string color)
    {
        string result = $"Taxi {id} ";
        switch (color)
        {
            case "GREEN":
                result += " races across";
                break;
            case "YELLOW":
                result += " speeds up, crosses while yelling TAXI GREEN";
                break;
            case "RED":
                result += " slams the breaks and comes to a screeching halt";
                break;
        }
        Console.WriteLine(result);
    }
}