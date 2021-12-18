using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //var parenteses_input = "{[()]}";
            //var parenteses_input = "{}[()]";
            //var parenteses_input = "{}[]()";
            //var parenteses_input = "{}[]";
            //var parenteses_input = "{]";
            var parenteses_input = "{}(}[)";

            var isblocked = Is_Blockeds(parenteses_input);

            Console.WriteLine(Is_Blockeds);

        }

        public static bool Is_Blockeds(string parenteses_input)
        {
            var parenteses = new string[] { "{}", "[]", "()" };
            char[] parenteses_array = parenteses_input.ToCharArray();
            var n = parenteses_array.Length / 2;
            var array_blocked = new string[n];
            var count_parenteses = parenteses.Length;
            var temp_array = array_blocked;
            var cont = 0;

            for (int i = 0; i < parenteses_array.Length; i++)
            {
                if ((i % 2) == 0)
                {
                    array_blocked[cont] = $"{parenteses_array[i]}{parenteses_array[i + 1]}";
                    cont = cont + 1;
                }
            }

            while (temp_array.Length > 0)
            {
                count_parenteses = count_parenteses - 1;

                if (count_parenteses == 0)
                    break;

                for (int i = 0; i < parenteses.Length; i++)
                    for (int j = 0; j < array_blocked.Length; j++)
                        if (array_blocked[j] == parenteses[i])
                        {
                            temp_array = RemoveItemArray(temp_array, array_blocked[j]);
                        }
            }

            return temp_array.Length == 0 ? true : false;
        }

        public static string[] RemoveItemArray(string[] array, string indice)
        {
            int removeIndex = Array.IndexOf(array, indice);

            if (removeIndex >= 0)
            {
                string[] newStrItems = new string[array.Length - 1];

                for (int i = 0, j = 0; i < newStrItems.Length; i++, j++)
                {

                    if (i == removeIndex)

                        j++;

                    newStrItems[i] = array[j];
                }


                return newStrItems;
            };


            return array;
        }
    }
}
