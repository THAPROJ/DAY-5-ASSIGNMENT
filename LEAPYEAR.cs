using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_5_ASSIGNMENT
{
    class LEAPYEAR

        {
            //method
            public void CheckLeapYear()
            {
                //initialization
                int year;
                //input
                Console.Write("Enter the Year :");
                year = int.Parse(Console.ReadLine());
                //Condition
                if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                    Console.WriteLine("Year is Leap Year");
                else
                    Console.WriteLine("Year is not a Leap Year");


                Console.ReadKey();
            }
        }
    }
