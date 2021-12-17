using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            var parenteses = new string[] { "{}", "[]", "()" };
            //var parenteses_input = "{[()]}";
            //var parenteses_input = "{}[()]";
            var parenteses_input = "{}[]()";
            //var parenteses_input = "{}";
            char[] parenteses_array = parenteses_input.ToCharArray();
            var n = parenteses_array.Length;
            var array_open = new char[n];
            var array_close = new char[n];

            for (int i = 0; i < n / 2; i++)
                array_open[i] = parenteses_array[i];

            var cont = 0;
            for (int i = n; i > 0; i--)
            {
                if ((i - 1) >= 3)
                {
                    array_close[cont] = parenteses_array[i - 1];
                    cont = cont + 1;
                }
            }

            string blockeds = "";

            for (int i = 0; i < parenteses.Length; i++)
            {
                blockeds = $"{array_open[i]}{array_close[i]}";

                if (blockeds == parenteses[i])

                    Console.WriteLine("true");
            }

        }
    }
}
