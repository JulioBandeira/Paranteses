using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            var parenteses = "{[()]}";

            char[] parenteses_array = parenteses.ToCharArray();

            for (int i = 0; i < parenteses_array.Length / 2; i++) { 
            
                Console.WriteLine(parenteses_array[i]);
                Console.WriteLine(i);
            }          

            Console.WriteLine("__________________________");

            for (int i = parenteses_array.Length; i > 0; i--)
            {
                if ((i - 1) >= 3)
                {
                    Console.WriteLine(parenteses_array[i - 1]);
                    Console.WriteLine(i);
                }
                    
            }
            

        }
    }
}
