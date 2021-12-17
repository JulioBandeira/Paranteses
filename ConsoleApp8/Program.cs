using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            var parenteses = new string[] { "{}", "[]", "()" };
            var parenteses_input = "{[()]}";
            //var parenteses_input = "{}[()]";
            //var parenteses_input = "{}[]()";
            //var parenteses_input = "{}[]";
            //var parenteses_input = "{}";
            char[] parenteses_array = parenteses_input.ToCharArray();
            var n = parenteses_array.Length;
            var array_open = new char[n];
            var array_close = new char[n];
            var array_close_open = new string[n];
            var temp_array = array_close_open;
            var cont_array_true = 0;

            for (int i = 0; i < n / 2; i++)
                array_open[i] = parenteses_array[i];

            var cont = 0;
            for (int i = n; i > 0; i--)
            {
              
                if ((i - 1) >= n/2)
                {
                    array_close[cont] = parenteses_array[i - 1];
                    cont = cont + 1;
                }
            }

            string blockeds = "";

            for (int i = 0; i < array_open.Length; i++) {

                blockeds = $"{array_open[i]}{array_close[i]}";

                for (int j = 0; j < parenteses.Length; j++)
                {
                    if (blockeds == parenteses[j]) {

                        cont_array_true = cont_array_true + 1;
                        Console.WriteLine(cont_array_true);
                    }

                }
            }

            Console.WriteLine((n/2) == cont_array_true ? true : false);

        }
    }
}
