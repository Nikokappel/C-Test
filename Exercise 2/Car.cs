﻿namespace Exercise_2;

public class Car
{
    private int id; 
    
    public Car(TrafficLight tl, int id)
    {
        this.id = id;
        tl.OnLightChange += ReactToLight;
    }
    
    private void ReactToLight(string color)
    {
        string result = $"Car {id} ";
        switch (color)
        {
            case "GREEN":
                result += " drives";
                break;
            case "YELLOW":
                result += " slows";
                break;
            case "RED":
                result += " stops";
                break;
        }
        Console.WriteLine(result);
    }

}