// See https://aka.ms/new-console-template for more information

using Harsha_Assessment_11_11_03_2023;

Console.WriteLine("Welcome to Returns Calculator");
//Console.WriteLine("Enter deposited date *InFormat(YYYY,MM,DD) : ");
//DateTime deposited = DateTime.Parse(Console.ReadLine());

//Console.WriteLine("Enter Withdrawal date *InFormat(YYYY,MM,DD) : ");
//DateTime Withdrawal = DateTime.Parse(Console.ReadLine());

//Console.WriteLine("Enter Amount : ");
//double amountDeposited = double.Parse(Console.ReadLine());


DateTime deposited = new DateTime(2022, 1, 1); // sample deposit date
DateTime withdrawal = new DateTime(2050, 3, 1); // sample withdrawal date
double amountDeposited = 1;
//TimeSpan month = 
double output = WithdrawalClass.AmountWithdreawal(deposited, withdrawal, amountDeposited);
Console.WriteLine(output.ToString("0.00"));