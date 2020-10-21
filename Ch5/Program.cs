using System;

namespace ch5
{
    class Program
    {
        static void Main(string[] args)
        {
        //     Console.WriteLine("Encapsulated Cars");

        //     Car myCar = new Car();
        //     myCar.petName = "Henry";
        //     myCar.currentSpeed = 10;
        //     Motorcycle.CngRoadConditions();

        //     for (int n = 0; n <= 10; n++)
        //     {
        //         myCar.SpeedUp(5);
        //         myCar.PrintState();
        //     }
        //     Console.ReadLine();
        // }

        System.Console.WriteLine("******Fun With Static Data******");
        SavingsAccount s1 = new SavingsAccount(50);
        SavingsAccount s2 = new SavingsAccount(100);
        SavingsAccount s3 = new SavingsAccount(10000.75);
    
        System.Console.WriteLine("Interest rate is {0}", SavingsAccount.GetInterestRate());
        Console.ReadLine();
        }
    }
}
