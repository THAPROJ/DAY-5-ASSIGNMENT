class Evenodd
{
    //method
    public void EvenOddFunction()
    {
        //initialization
        int number;
        Console.WriteLine("Enter a Number:");
        number = int.Parse(Console.ReadLine());
        //Condition 
        if (number % 2 == 0)
        {
            Console.WriteLine("Number is Even");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Number is Odd");
            Console.ReadLine();
        }
    }
}
