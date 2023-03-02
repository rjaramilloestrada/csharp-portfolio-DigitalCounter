using System;

namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string enteredText = "";
            
            while (enteredText.Equals(""))
            {
                Console.WriteLine("Please press enter to increase the amount by one and anything else" + 
                    " + enter if you want to finish counting");
                enteredText = Console.ReadLine();

                counter++;
                Console.WriteLine("Current people is {0}", counter);

            }
            Console.WriteLine("{0} people are inside the bus. Press enter to end te program", counter);
            Console.Read();
        }
    }
}
