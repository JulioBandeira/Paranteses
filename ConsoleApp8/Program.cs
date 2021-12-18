using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            var parenteses_input = "{[()]}";
            Blockeds(parenteses_input);
            OpenCloseArray();
        }

        public static void Blockeds(string parenteses_input) {

            var parenteses = new string[] { "{}", "[]", "()" };
           
            //var parenteses_input = "[]{}{]";
            //var parenteses_input = "{}[]()";
            //var parenteses_input = "{}[]";
            //var parenteses_input = "{}";
            char[] parenteses_array = parenteses_input.ToCharArray();
            var n = parenteses_array.Length / 2;
            var array_blocked = new string[n];
            var cont_array_true = 0;
            var str_array = array_blocked;


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


            for (int i = 0; i < parenteses.Length; i++)
            {
                for (int j = 0; j < array_blocked.Length; j++)
                {
                    if (array_blocked[j] == parenteses[i])
                    {

                        str_array = RemoveItemArray(str_array, array_blocked[i]);

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

        public static string[] RemoveItemArray(string[] array, string indice)
        {

            int removeIndex = Array.IndexOf(array, indice);

            if (removeIndex >= 0)
            {
                // declare and define a new array one element shorter than the old array
                string[] newStrItems = new string[array.Length - 1];

                // loop from 0 to the length of the new array, with i being the position
                // in the new array, and j being the position in the old array
                for (int i = 0, j = 0; i < newStrItems.Length; i++, j++)
                {
                    // if the index equals the one we want to remove, bump
                    // j up by one to "skip" the value in the original array
                    if (i == removeIndex)
                    {
                        j++;
                    }

                    // assign the good element from the original array to the
                    // new array at the appropriate position
                    newStrItems[i] = array[j];
                }

                // overwrite the old array with the new one
                return newStrItems;
            };


            return new string[] { };
        }
    }
}
