using DAY_5_ASSIGNMENT;

namespace DAY5ASSIGNMENT
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t=====================List Of Basic Programs==================");
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\t1.Flip Coin");
            Console.WriteLine("\t\t\t\t\t\t2.Leap Year");
            Console.WriteLine("\t\t\t\t\t\t3.Power of 2");
            Console.WriteLine("\t\t\t\t\t\t4.Harmonic Number");
            Console.WriteLine("\t\t\t\t\t\t5.Factor");
            Console.WriteLine("\t\t\t\t\t\t6.Compute Quotient and Remainder");
            Console.WriteLine("\t\t\t\t\t\t7.Swap Two Numbers");
            Console.WriteLine("\t\t\t\t\t\t8.Even and Odd");
            Console.WriteLine("\t\t\t\t\t\t9.Alphabet is Vowel And Consonant");
            Console.WriteLine("\t\t\t\t\t\t10.Largest Among 3 numbers");

            int choice;
            Console.Write("\t\t\t\t\t\t ENTER YOUR CHOICE:");

            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Welcome To Flip Coin Program ");
                   Flip_Coin coin = new Flip_Coin();
                    coin.FlipCoinProgram();
                    break;

                case 2:
                    Console.WriteLine("Welcome to Year of Program ");
                    LEAPYEAR y = new LEAPYEAR();
                    y.CheckLeapYear();
                    break;

                case 3:
                    Console.WriteLine("Welcome to Power of 2 Program ");
                    POWER Power = new POWER();
                    Power.Power();
                    break;

                case 4:
                    Console.WriteLine("Welcome to Harmonic Number Program ");
                    HarmonicNumber harmonic = new HarmonicNumber();
                    harmonic.Harmonic();
                    break;

                case 5:
                    Console.WriteLine("Welcome to Factor Program ");
                     FACTOR factor = new FACTOR();
                    factor.Factor();
                    break;

                case 6:
                    Console.WriteLine("Welcome To Division Program ");
                   REMAINDER_QUOTIENT div = new REMAINDER_QUOTIENT();
                    div.Division();
                    break;

                case 7:
                    Console.WriteLine("Welcome To Swapping Program ");
                    SWAPNUMBER swap  = new SWAPNUMBER();
                    swap.Swapping(); 
                    break;

                case 8:
                    Console.WriteLine("Welcome To Even and Odd Program");
                    Evenodd num = new Evenodd();
                    num.EvenOddFunction();
                    break;

                case 9:
                    Console.WriteLine("Welcome to Alphabet is Vowel And Consonant");
                    Alphabet alphabet = new Alphabet();
                    Alphabet.Vowels();
                    break;


                case 10:
                    Console.WriteLine("Welcome to Largest Program ");
                    LARGESTNUMBER largest = new LARGESTNUMBER();
                    largest.Largest();
                    break;
            }
        }

    }
}