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
            var n = parenteses_array.Length / 2;
            var array_blocked = new string[n];
            var cont_array_true = 0;
            var str_array = "";

            var cont = 0;
            for (int i = 0; i < parenteses_array.Length; i++)
            {
                if ((i % 2) == 0)
                {

                    //Console.WriteLine($"{(i % 2) == 0}");
                    //Console.WriteLine($"{parenteses_array[i]}{parenteses_array[i + 1]}");
                    //Console.WriteLine($"{parenteses_array[i]}{parenteses_array[i + 1]}");
                    array_blocked[cont] = $"{parenteses_array[i]}{parenteses_array[i + 1]}";
                    cont = cont + 1;
                }
            }


            for (int i = 0; i < array_blocked.Length; i++)
            {
                str_array += array_blocked[i];
                Console.WriteLine(str_array);

                for (int j = 0; j < parenteses.Length; j++)
                {
                    if (array_blocked[i] == parenteses[j])
                    {
                        cont_array_true = cont_array_true + 1;
                    }                          
                }
            }

        }

        public static void OpenCloseArray()
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

                if ((i - 1) >= n / 2)
                {
                    array_close[cont] = parenteses_array[i - 1];
                    cont = cont + 1;
                }
            }

            string blockeds = "";

            for (int i = 0; i < array_open.Length; i++)
            {

                blockeds = $"{array_open[i]}{array_close[i]}";

                for (int j = 0; j < parenteses.Length; j++)
                {
                    if (blockeds == parenteses[j])
                    {

                        cont_array_true = cont_array_true + 1;
                        Console.WriteLine(cont_array_true);
                    }

                }
            }

            Console.WriteLine((n / 2) == cont_array_true ? true : false);

        }
    }
}
