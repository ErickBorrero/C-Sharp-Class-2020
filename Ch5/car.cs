using System;

class Car 
{
    public string petName;
    public int currentSpeed;

    public void PrintState()
    {
        System.Console.WriteLine("{0} is going {1} MPH.", petName, currentSpeed);
    }

    public void SpeedUp(int delta)
    {
        currentSpeed += delta;
    }
}

 class Motorcycle 
 {
     public int driverIntensity;
     public string name;

     public void SetDriverName(string name) => name = this.name;
     public void PopAWheely() 
     {
         System.Console.WriteLine("Yeeeeee Haaaaaaaaw!!!!!");
     }

     public static void CngRoadConditions()
     {
         System.Console.WriteLine("You Done");
     }
 }