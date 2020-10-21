using System;

class SavingsAccount
{
    public double currentBalance;
    public static double currentInterestRate = 0.04;
    
    public SavingsAccount(double balance)
    {
        currentBalance = balance;
    } 
    public static void SetInterestRate(double newRate)
    {
        currentInterestRate = newRate;
    }

    public static double GetInterestRate()
    {
        return currentInterestRate;
    }
}