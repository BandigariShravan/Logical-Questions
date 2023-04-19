// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

//Stopwatch sw= Stopwatch.StartNew();
try
{
    Console.WriteLine("Enter a number to get its Highest value ");
    int number = int.Parse(Console.ReadLine());

    //int start = 1;
    int factor = 1;
    for (int i = 2; i<=number/2; i++)
    {
        if (number%i==0)
        {
            factor=i;
        }
    }
    Console.WriteLine(factor);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}