namespace Exercise_2;

public class Pedestrian
{
    private int id; 
    
    public Pedestrian(TrafficLight tl, int id)
    {
        this.id = id;
        tl.OnLightChange += ReactToLight;
    }
    
    private void ReactToLight(string color)
    {
        string result = $"Pedestrian {id} ";
        switch (color)
        {
            case "GREEN":
                result += " Waits";
                break;
            case "YELLOW":
                result += " Waits for taxis";
                break;
            case "RED":
                result += " Crosses the road";
                break;
        }
        Console.WriteLine(result);
    }
}