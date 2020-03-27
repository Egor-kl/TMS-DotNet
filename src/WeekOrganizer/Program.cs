using System;
using System.Collections.Generic;

namespace WeekOrganizer
{
    class Program
    {
        static List<string> taskDayMonday = new List<string>() { };
        static List<string> taskDayTuesday = new List<string>() { };
        static List<string> taskDayWednesday = new List<string>() { };
        static List<string> taskDayThursday = new List<string>() { };
        static List<string> taskDayFriday = new List<string>() { };
        static List<string> taskDaySaturday = new List<string>() { };
        static List<string> taskDaySunday = new List<string>() { };
        enum daysOfWeek{ Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6, Sunday = 7 }
        static void Main(string[] args)
        {
            Console.WriteLine("Write 'W' to continue, if you need some help write 'H' ");
            string userInput = Console.ReadLine();
            if (userInput == "W" || userInput == "w")
            {           
                checkInput();
            }
            else if (userInput == "h" || userInput == "H")
            {
                Help();
            }
            else
            {
                Console.WriteLine("WHY YOU WRITE THIS????? I SAY YOU WRITE 'W' OR 'H'!"); //lul
                Environment.Exit(0);
            }
        }
        public static void Help()
        {
            Console.WriteLine("Okay, it's little tutorial.");
            Console.WriteLine("You need to choose one of the 7 days of the week, write in full (For example 'Monday' or 'mon' or '1', 'Tuesday' or 'Tus' or '2', etc.) ");
            Console.WriteLine("This application works easily, you choose a day and write down your tasks for that day, so you can schedule all for a whole week, after each recording you will be asked to double-check what you wrote");
        }
        
        public static string checkInput()
        {
            
            Console.WriteLine("Okay, if you need see what you write press 'L',\nif you need continue program press 'W' ");
            string userInput2 = Console.ReadLine();
            if (userInput2 == "W" || userInput2 == "w")
            {
                inpDay();
            }
            else if (userInput2 == "L" || userInput2 == "l")
            {
                checkList();
            }

            return checkInput();

        }
        public static void inpDay()
        {
            Console.Write("Choose day of the week: ");
            string inputDay = Console.ReadLine();
            switch (inputDay)
            {
                case "Monday": case "monday": case "1":
                    Console.Write("Okay, write something: ");
                    string mon1 = Console.ReadLine();
                    taskDayMonday.Add(mon1);
                    Console.WriteLine("I am add your task in list");
                    break;
                case "Tuesday": case "tuesday": case "2":
                    Console.Write("Okay, write something: ");
                    string tue1 = Console.ReadLine();
                    taskDayTuesday.Add(tue1);
                    Console.WriteLine("I am add your task in list");
                    break;
                case "Wednesday": case "wednesday": case "3":
                    Console.Write("Okay, write something: ");
                    string wed1 = Console.ReadLine();
                    taskDayWednesday.Add(wed1);
                    Console.WriteLine("I am add your task in list");
                    break;
                case "Thursday": case "thursday": case "4":
                    Console.Write("Okay, write something: ");
                    string thu1 = Console.ReadLine();
                    taskDayThursday.Add(thu1);
                    Console.WriteLine("I am add your task in list");
                    break;
                case "Friday": case "friday": case "5":
                    Console.Write("Okay, write something: ");
                    string fri1 = Console.ReadLine();
                    taskDayFriday.Add(fri1);
                    Console.WriteLine("I am add your task in list");
                    break;
                case "Saturday": case "saturday": case "6":
                    Console.Write("Okay, write something: ");
                    string sat1 = Console.ReadLine();
                    taskDaySaturday.Add(sat1);
                    Console.WriteLine("I am add your task in list");
                    break;
                case "Sunday": case "sunday": case "7":
                    Console.Write("Okay, write something: ");
                    string sun1 = Console.ReadLine();
                    taskDaySunday.Add(sun1);
                    Console.WriteLine("I am add your task in list");
                    break;
            }
        }
        public static void checkList()
        {
            Console.Write("Choose day of the week: ");
            string inputDay2 = Console.ReadLine();
            switch (inputDay2)
            {
                case "Monday": case "monday": case "1":
                    for (int i = 0; i < taskDayMonday.Count; i++)
                    {
                        Console.WriteLine($"You choose {daysOfWeek.Monday}");
                        Console.WriteLine(taskDayMonday[i]);
                    }
                    break;
                case "Tuesday":case "tuesday": case"2":
                    for (int i = 0; i < taskDayTuesday.Count; i++)
                    {
                        Console.WriteLine($"You choose {daysOfWeek.Tuesday}");
                        Console.WriteLine(taskDayTuesday[i]);
                    }
                    break;
                case "Wednesday": case "wednesday" : case "3":
                    for (int i = 0; i < taskDayWednesday.Count; i++)
                    {
                        Console.WriteLine($"You choose {daysOfWeek.Wednesday}");
                        Console.WriteLine(taskDayWednesday[i]);
                    }
                    break;
                case "Thursday": case "thursday":case "4":
                    for (int i = 0; i < taskDayThursday.Count; i++)
                    {
                        Console.WriteLine($"You choose {daysOfWeek.Thursday}");
                        Console.WriteLine(taskDayThursday[i]);
                    }
                    break;
                case "Friday": case "friday": case "5":
                    for (int i = 0; i < taskDayFriday.Count; i++)
                    {
                        Console.WriteLine($"You choose {daysOfWeek.Friday}");
                        Console.WriteLine(taskDayFriday[i]);
                    }
                    break;
                case "Saturday":case "saturday": case "6":
                    for (int i = 0; i < taskDaySaturday.Count; i++)
                    {
                        Console.WriteLine($"You choose {daysOfWeek.Saturday}");
                        Console.WriteLine(taskDaySaturday[i]);
                    }
                    break;
                case "Sunday":case "sunday": case "7":
                    for (int i = 0; i < taskDaySunday.Count; i++)
                    {
                        Console.WriteLine($"You choose {daysOfWeek.Sunday}");
                        Console.WriteLine(taskDaySunday[i]);
                    }
                    break;
            }
            
            
        }
    }
}
