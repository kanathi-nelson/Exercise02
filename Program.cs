using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            long val;
            Console.Write("Enter number: ");
            string inputval = Console.ReadLine();
            try
            {
                val = Convert.ToInt64(inputval);
                string mynumber = Exercise01.Class1.Towards(val);
                Console.WriteLine(mynumber);

                Console.WriteLine("Exiting...");
            }
            catch
            {
                Console.WriteLine("Enter a valid string!");
                throw;
            }
            
        }
    }
}
