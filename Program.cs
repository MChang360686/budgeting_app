using System;
using System.Globalization;

namespace Program
{ 
    //The idea of this app is to partially set a budget,
    //but also to see how much someone would need to make 
    //to live

    class budget{
        public static Double divideDays(int time, int money){
            Double cpd = money/time;
            return cpd;
        }

        public static Double divideMonths(int time, int money){
            Double cpm = divideDays(time, money) * 30;
            return cpm;
        }

        public static Double divideYears(int time, int money){
            Double cpy = divideMonths(time, money) * 12;
            return cpy;
        }
    }

    class budgeter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Budget App");
            Console.WriteLine("Please enter length of time to budget");
            int time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Days (1), Months(2), Years(3)?");
            int timeUnits = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much Currency do you wish to allocate?");
            int money = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much are your Food Costs per diem?");
            int foodOverhead = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much are your Medical Bills per diem?");
            int medicalOverhead = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much are your Transportation Costs per diem?");
            int transportationOverhead = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much is your Rent per diem?");
            int rentOverhead = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much are your Other Costs per diem?");
            int otherOverhead = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much Pocket money do you want per time unit per diem?");
            int pocketMoney = Convert.ToInt32(Console.ReadLine());
            int totalCost = foodOverhead + medicalOverhead + transportationOverhead 
            + rentOverhead + otherOverhead;

            if(timeUnits == 1){
                Double costPerDay = budget.divideDays(time, totalCost);
                Console.WriteLine("Your budget is " + costPerDay + " per day");
            }else if(timeUnits == 2){
                Double costPerMonth = budget.divideMonths(time, totalCost);
                Console.WriteLine("Your budget is " + costPerMonth + " per month");
            }else if(timeUnits == 3){
                Double costPerYear = budget.divideYears(time, totalCost);
                Console.WriteLine("Your budget is " + costPerYear + " per year");
            }

        }
    }
}