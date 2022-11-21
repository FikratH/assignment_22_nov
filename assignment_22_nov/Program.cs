namespace assignment_22_nov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string again = "yes";
            while (again == "yes")
            {
                try
                {
                    Console.WriteLine("Please, enter a number:");
                    int num = Convert.ToInt32(Console.ReadLine());
                    isDividedBy7(num);
                    Console.WriteLine("Do you want to start over? (yes/no)");
                    again = Console.ReadLine();
                    Console.WriteLine("");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unexpected Error! Error info: " + ex.Message);
                }
            }
        }
        static void isDividedBy7 (int number)
        {
            int initNum = number;
            int number2 = number;
            int count1 = 0;
            int count2 = 0;
            if (number%7==0)
            {
                Console.WriteLine("The number " + initNum + " can be divided by 7");
            } else
            {
                while (number%7!=0)
                {
                    number++;
                    count1++;
                }
                while (number2%7!=0)
                {
                    number2--;
                    count2++;
                }
                if (count1 > count2)
                {
                    Console.WriteLine("\nThe closest number that can be divided by 7 is " + number2 + "\n");
                } else
                {
                    Console.WriteLine("\nThe closest number that can be divided by 7 is " + number + "\n");
                }
            }
        }
    }
}