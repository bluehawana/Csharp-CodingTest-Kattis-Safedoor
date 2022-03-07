using System;
using System.Collections.Generic;

namespace KatisSecureDoor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please input the number of lines you want to input");
            int input = int.Parse(Console.ReadLine());
            //set the range of tracking(The max value of the loop the user could input and print out)
           
            Console.WriteLine($"Please enter {input} st data of emplyee's actions below:");
            //input the data 1 line by 1 line to be executed by the program

            List<string> Entered = new List<string>();
            List<string> Exited = new List<string>();
            //created two new lists of strings to check if the name is repeated or not

            for (int i = 0; i < input; i++)
            {
                string[] split = Console.ReadLine().Split(' ');
                //method to split name and action from user input of readline

                string mode = split[0];
                string name = split[1];
                //since the format is "entry someone", "exit someone" in input, so 0 positions should be the action and 1 should be the name of the employee

                if (mode == "entry")
                    {
                        if (!Entered.Contains(name))
                        {
                            Console.WriteLine($"{name} entered");
                            Entered.Add(name);
                            Exited.Remove(name);
                        }
                        else
                        {
                            Console.WriteLine($"{name} entered (ANOMALY)");
                        }
               // under "entry" mode,how to detect whether the person is in the building or not via if...else
                    }

                    if (mode == "exit")
                    {
                        if (Exited.Contains(name) || !Entered.Contains(name))
                        {
                            Console.WriteLine($"{name} exited (ANOMALY)");
                        }
                        else
                        {
                            Console.WriteLine($"{name} exited");
                            Entered.Remove(name);
                        }
                    // under "exit" mode,how to detect whether the person is out the building or not via if...else
                     }
            }
            Console.ReadKey();
        }
   
        }
   

    }
