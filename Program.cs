using System;
using System.Globalization;

namespace Program
{ 
    //The idea of this app is to partially set a budget,
    //but also to see how much someone would need to make 
    //to live

    class budget{
        public static Double days(int time, int money){
            Double cpd = money * time;
            return cpd;
        }

        public static Double months(int time, int money){
            Double cpm = days(time, money) * 30;
            return cpm;
        }

        public static Double years(int time, int money){
            Double cpy = months(time, money) * 12;
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
            + rentOverhead + otherOverhead + pocketMoney;

            if(timeUnits == 1){
                Double costPerDay = budget.days(time, totalCost);
                Console.WriteLine("For a budget of " + totalCost + " per day over a period of " 
                + time + " days You would need to earn " + costPerDay);
            }else if(timeUnits == 2){
                Double costPerMonth = budget.months(time, totalCost);
                Console.WriteLine("For a budget of " + totalCost + " per day over a period of " 
                + time + " months You would need to earn " + costPerMonth);
            }else if(timeUnits == 3){
                Double costPerYear = budget.years(time, totalCost);
                Console.WriteLine("For a budget of " + totalCost + " per day over a period of " 
                + time + " years You would need to earn " + costPerYear);
            }

        }
    }
}
