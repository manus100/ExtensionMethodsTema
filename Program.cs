using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsTema
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "ana are mere";
            string str = "method";
            decimal value;

            var newList = Swap<string>(new List<string> { "abc", "def", "ghi", "jklm" }, 1, 3);
            var newListInt = Swap<int>(new List<int> { 1, 2, 3, 4, 5 }, 0, 2);

            Console.WriteLine("Write an extension method to check if a string starts with a capital letter or not.");
            Console.WriteLine(sentence + "--> " + sentence.CheckIfCapital());
            Console.WriteLine();


            Console.WriteLine("Write an extension method that appends an ‘s’ to a string.");
            Console.WriteLine(str + "--> " + str.PluralizeString()); 
            Console.WriteLine();

            Console.WriteLine("Write an extension method that will capitalize a word.");
            str = "mom";
            Console.WriteLine(str + "--> " + str.CapitalizeWord());
            Console.WriteLine();

            //Capitalize and pluralize
            Console.WriteLine("Capitalize and pluralize a string");
            str = "rabbit";
            Console.Write(str + "--> ");
            str = str.CapitalizeWord();
            Console.WriteLine(str.PluralizeString());
            Console.WriteLine();

            //Character count
            Console.WriteLine("Write an extension method what will count the number of characters in a string.");
            Console.WriteLine(sentence + "-->" + sentence.CharacterCount());
            Console.WriteLine();

            //Apply VAT
            Console.WriteLine("Write an extension method that will apply a VAT of 24% on an input. This input can be a decimal value");
            Console.WriteLine("Enter a decimal value: ");
            value = decimal.Parse(Console.ReadLine());
            Console.WriteLine(value + " + 24%VAT " + value.ApplyVAT());



            Console.ReadLine();
        }



        //Create a generic method that receives a list containing any type of data and swaps the elements at two given indexes.
        static List<T> Swap<T>(List<T> list, int idx1, int idx2)
        {
            var temp = list[idx1];
            list[idx1] = list[idx2];
            list[idx2] = temp;

            return list;
        }
    }
}
