namespace Harsha_Assessment_11_11_03_2023
{
    public class WithdrawalClass
    {
        public static double AmountWithdreawal(DateTime depositDate, DateTime withdrawalDate, double amountDeposited)
        {
            double interestRate = 0.15;
            double marginDeductionRate = 0.03;

            double amountWithdrawn = amountDeposited;
            DateTime startDate = depositDate.AddDays(1);

            if (withdrawalDate.Day <= 10 && withdrawalDate.Month == startDate.Month)
            {
                double interestRateForFirst10Days = 0.12;
                int daysInFirst10Days = withdrawalDate.Day - startDate.Day;
                double interestEarned = amountDeposited * (interestRateForFirst10Days / 365) * daysInFirst10Days;
                amountWithdrawn = amountDeposited + interestEarned;
            }
            else
            {
                DateTime currentDate = startDate;
                int holdingPeriodInDays = (withdrawalDate - startDate).Days;
                //Console.WriteLine("Days:"+holdingPeriodInDays);
                while (currentDate < withdrawalDate)
                {
                    DateTime endOfMonth = new DateTime(currentDate.Year, currentDate.Month, DateTime.DaysInMonth(currentDate.Year, currentDate.Month));
                    int daysInMonth = (endOfMonth - currentDate).Days + 1;
                    //Console.WriteLine("Days in Month of "+currentDate.Month+" : "+daysInMonth);
                    double interestEarned = amountWithdrawn * (interestRate / 365) * daysInMonth;
                    //Console.WriteLine("Intrest Earned: "+interestEarned);
                    amountWithdrawn += interestEarned;

                    if (currentDate.Day <= 10)
                    {
                        double interestRateForFirst10Days = 0.12;
                        int daysInFirst10Days = Math.Min(10 - currentDate.Day + 1, daysInMonth);
                        double interestEarnedForFirst10Days = amountWithdrawn * (interestRateForFirst10Days / 365) * daysInFirst10Days;
                        amountWithdrawn += interestEarnedForFirst10Days;
                    }
                    //Console.WriteLine("Updated Amount : "+amountWithdrawn.ToString("0.00"));
                    currentDate = endOfMonth.AddDays(1);
                }

                if (holdingPeriodInDays > 10)
                {
                    double marginDeduction = 0;
                    DateTime marginStartDate = withdrawalDate.AddDays(-10);
                    int marginDays = (withdrawalDate - marginStartDate).Days - 1;

                    if (marginDays > 0)
                    {
                        double marginInterestRate = interestRate / 365 * marginDays;
                        marginDeduction = amountWithdrawn * marginInterestRate * marginDeductionRate;
                    }

                    amountWithdrawn -= marginDeduction;
                }
            }

            return amountWithdrawn;



            //int daysInMonthOfDeposited = DateTime.DaysInMonth(deposited.Year, Withdrawal.Year);

            //if (deposited.Year==Withdrawal.Year && deposited.Month ==Withdrawal.Month)
            //{
            //    //daysInMonthOfDeposited=Withdrawal.Day-deposited.Day;
            //    daysInMonthOfDeposited=daysInMonthOfDeposited-deposited.Day;
            //}
            //Console.WriteLine(daysInMonthOfDeposited);

            //int daysInMonthOfWithdrawal = DateTime.DaysInMonth(Withdrawal.Year, Withdrawal.Month);


            //if (Withdrawal.Year==Withdrawal.Year && Withdrawal.Month ==Withdrawal.Month)
            //{
            //    daysInMonthOfWithdrawal=daysInMonthOfWithdrawal-Withdrawal.Day-1;
            //}
            //Console.WriteLine(daysInMonthOfWithdrawal);












            //double intrestRate = 0.15M;
            //double marginRate = 0.15M;
            //double amountWithdrawal = amountDeposited;
            //while (depositDate<withdrawalDate)
            //{
            //    if (withdrawalDate.Day<=10 && withdrawalDate.Month==depositDate.Month)
            //    {
            //        double intrestRateFor10Days = 0.15M;
            //        double intrestCredited = amountDeposited*(intrestRateFor10Days/365)*100;
            //        double marginDeduction = amountDeposited*marginRate;
            //        amountWithdrawal=amountDeposited+intrestCredited-marginDeduction;
            //    }
            //    else
            //    {
            //        int daysOfAmountInBank = (withdrawalDate-depositDate).Days;
            //        double intrestCredited = amountDeposited*(intrestRate/365)*daysOfAmountInBank;
            //        amountWithdrawal=amountDeposited+intrestCredited;
            //    }
            //    //withdrawalDate=
            //}
            //return amountWithdrawal;










            //TimeSpan daysDiffrence = (deposited - Withdrawal);
            //int totalDays = (int)Math.Abs(daysDiffrence.TotalDays);
            //Console.WriteLine(totalDays.ToString().ToString());

            //int annualIntrest = 0;
            //double dailyIntrest = 0;
            //double monthlyIntrest = 0;
            //double intrestForMonth = 0;


            //if (deposited.Day>1 && deposited.Day<=10)
            //{
            //    annualIntrest = 12;
            //    dailyIntrest = (annualIntrest/365)*daysInMonthOfDeposited;

            //    monthlyIntrest = (annualIntrest/12);


            //    intrestForMonth = (amountDeposited *monthlyIntrest*daysInMonthOfDeposited)/100;

            //}
            ////if (deposited.Day>10)// &&deposited.Day)
            //else
            //{
            //    annualIntrest = 15;
            //    dailyIntrest = (annualIntrest/365)*daysInMonthOfDeposited;

            //    monthlyIntrest = (annualIntrest/12);


            //    intrestForMonth = (amountDeposited *monthlyIntrest*daysInMonthOfDeposited)/100;

            //}

            //double TotalAmountWithdrawal = amountDeposited+intrestForMonth;
            //return TotalAmountWithdrawal;

            //Console.WriteLine(amountDeposited+dailyIntrest+" "+amountDeposited+monthlyIntrest+" "+amountDeposited+intrestForMonth);

            //dailyIntrest = (15/365)*totalDays;

            //monthlyIntrest = (annualIntrest/12);


            //intrestForMonth = (amountDeposited *monthlyIntrest*totalDays)/100;


        }
    }
}
