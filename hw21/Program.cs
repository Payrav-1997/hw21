using System;

using System.Collections.Generic;

using System.Collections.Immutable;

using System.ComponentModel.Design;

using System.Linq;

using System.Runtime.CompilerServices;

namespace Hw21

{

    class Program

    {

        static void Main(string[] args)

        {

            //Задача 1


            //    Console.WriteLine("Наберите слово => aeiou");
            //    Console.WriteLine(new string('=',25));
            //    string letter = "aeiou";

            //    string input = Console.ReadLine();

            //    var res = new string(input.Select((i) => (letter.Contains(i) ? 
            //                        ((char)((int)48 + letter.IndexOf(i) + 1)) 
            //                        : i)).ToArray());

            //    Console.WriteLine(res);

            //////Задача 2


            //    Console.WriteLine("Наберите число => 1,2,3,4,5");

            //    Console.WriteLine(new string('=', 25));

            //    string num = "12345";

            //    string letter = "aeiou";

            //    string input = Console.ReadLine();

            //    var res = new string(input.Select((i) => num.Contains(i) ?
            //                        letter.ElementAtOrDefault(num.IndexOf(i))
            //                        : i).ToArray());

            //    Console.WriteLine(res);

            ////Задача 3



            //    string letter = "fsfd23sdf+dsf2";

            //    var operation = (letter.Where(i => Char.IsPunctuation(i)).ToArray()[0]);

            //    var text = new string(letter.Where(i => Char.IsDigit(i) || 
            //                         char.IsPunctuation(i)).ToArray()).
            //                         Split(operation);

            //    double num = double.Parse(text[0]);

            //    double num2 = double.Parse(text[1]);

            //    if (operation == '+')
            //    {
            //        Console.WriteLine(num + num2);
            //    }

            //    if (operation == '-')
            //    {
            //        Console.WriteLine(num - num2);
            //    }

            //    if (operation == '*')
            //    {
            //        Console.WriteLine(num * num2);
            //    }

            //    if (operation == '/')
            //    {
            //        Console.WriteLine(num / num2);
            //    }

            ////Задача 4 


            //Console.WriteLine("Наберите слово camelCasing");

            //string letter = Console.ReadLine();

            //var res = letter.Select((i) => i.ToString()).Select(((item) =>
            //             char.IsUpper(char.Parse(item)) ? " "
            //             + item : item)).ToArray().Aggregate((i, t) => i + t);

            //Console.WriteLine(res);





        }

    }

}