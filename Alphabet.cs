using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_5_ASSIGNMENT
{
    internal class Alphabet
    {
            public static void Vowels()
            {
                Console.WriteLine("Enter a Alphabet");
            char ch = Convert.ToChar(value: Console.ReadLine().ToLower()) ;
                switch (ch)
                {
                    case 'a':
                        Console.WriteLine("It is vowel");
                        break;
                    case 'i':
                        Console.WriteLine("It is vowel");
                        break;
                    case 'o':
                        Console.WriteLine("It is vowel");
                        break;
                    case 'u':
                        Console.WriteLine("It is vowel");
                        break;
                    case 'e':
                        Console.WriteLine("It is vowel");
                        break;
                    default:
                        Console.WriteLine("It Is Not Vowel");
                        break;
                }
                         Console.ReadKey();
            }
        
    }
}
