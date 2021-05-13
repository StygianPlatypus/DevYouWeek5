using System;

namespace VacationBudgetPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = false;
            int twoFour = 24;
            int fourteenForty = 1440;
            string password = "tripYourFaceOff";
            for (int i = 3; i > 0; i--)
            {
                Console.WriteLine("Please enter the password to gain access to the Vacation Budget Planner XL.");
                string userPass = Console.ReadLine();
                if (userPass == password)
                {
                    run = true;
                    break;
                }               
                if ((userPass != password) && (i == 1))
                {
                    Console.WriteLine("You have been locked out from this service due to multiple incorrect password inputs.");
                }
                else
                {
                    Console.WriteLine($"The password you entered is incorrect. {i-1} attempts left.");
                }
            }            
            while (run == true)
            {
                bool destination = true;
                Console.WriteLine("Welcome to the Vacation Budget Planner XL!\r\nWhat is your name?");
                string name = Console.ReadLine();
                Console.WriteLine($"Hello {name}!");
                while (destination == true)
                {
                    Console.WriteLine("Would you like to travel to Mexico or Jamaica?");
                    string where = Console.ReadLine();
                    switch (where)
                    {
                        case "Jamaica":
                        case "jamaica":
                            Console.WriteLine("Wow! Jamaica sounds like an amazing trip.");
                            Console.WriteLine("************");
                            Console.WriteLine("How many days will you be spending in Jamaica?");
                            int jamDays = Int16.Parse(Console.ReadLine());
                            Console.WriteLine("How much spending money do you have for your trip?");
                            double jamMoney = double.Parse(Console.ReadLine());
                            int jamHours = (jamDays * twoFour);
                            int jamMinutes = (jamDays * fourteenForty);
                            Console.WriteLine($"You'll be spending a glorious {jamHours} hours in beautiful Jamaica. That's {jamMinutes} minutes!");
                            double jamDayMoney = (jamMoney / jamDays);
                            double jamaicanDollars = 150.87;
                            double dayMoneyJam = (jamDayMoney * jamaicanDollars);
                            Console.WriteLine($"Well, {name}, it looks like you will be spending {jamDays} days in Jamaica with {jamMoney:c} to spend.\r\nThat means you can spend up to {jamMoney / jamDays:c} per day while you are there.\r\n" +
                                $"In Jamaican Dollars, that would be {jamMoney * jamaicanDollars:c} for {jamDays} days, or {dayMoneyJam:c} per day.");
                            Console.WriteLine($"Enjoy your trip to Jamaica!, {name}!");
                            bool loop = true;
                            do
                            {
                                Console.WriteLine("Would you like to run the Vacation Budget Planner XL again? y/n");
                                string again = Console.ReadLine();
                                if (again == "y")
                                {
                                    destination = false;
                                    break;
                                }
                                if (again == "n")
                                {
                                    destination = false;
                                    run = false;                                    
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a valid input.");
                                }
                            } while (loop == true);
                            break;
                        case "Mexico":
                        case "mexico":
                            Console.WriteLine("Awesome! Mexico sounds like an amazing trip.");
                            Console.WriteLine("************");
                            Console.WriteLine("How many days will you be spending in Mexico?");
                            int days = Int16.Parse(Console.ReadLine());
                            Console.WriteLine("How much spending money do you have for your trip?");
                            double money = double.Parse(Console.ReadLine());
                            int hours = (days * twoFour);
                            int minutes = (days * fourteenForty);
                            Console.WriteLine($"You'll be spending a glorious {hours} hours in sunny Mexico. That's {minutes} minutes!");
                            double dayMoney = (money / days);
                            double pesos = 20.17;
                            double dayMoneyPesos = (dayMoney * pesos);
                            Console.WriteLine($"Well, {name}, it looks like you will be spending {days} days in Mexico with {money:c} to spend.\r\nThat means you can spend up to {money / days:c} per day while you are there.\r\n" +
                                $"In Pesos, that would be {money * pesos:c} for {days} days, or {dayMoneyPesos:c} per day.");
                            Console.WriteLine($"Enjoy your trip to Mexico, {name}!");
                            bool loop1 = true;
                            do
                            {
                                Console.WriteLine("Would you like to run the Vacation Budget Planner XL again? y/n");
                                string again = Console.ReadLine();
                                if (again == "y")
                                {
                                    destination = false;
                                    break;
                                }
                                if (again == "n")
                                {
                                    destination = false;
                                    run = false;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a valid input.");
                                }
                            } while (loop1 == true);
                            break;
                        default:
                            Console.WriteLine("Please enter a valid input.");
                            break;
                    }
                }
            }
        }
    }
}
