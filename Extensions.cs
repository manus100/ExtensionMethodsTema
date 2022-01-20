using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsTema
{
    public static class Extensions
    {

        //Write an extension method to check if a string starts with a capital letter or not.
        public static bool CheckIfCapital(this string strToCheck)
        {
            char chr = strToCheck[0];
            return Char.IsUpper(chr);

            //if (strToCheck[0] == strToCheck.ToUpper()[0])
            //    return true;
            //else
            //    return false;

        }

        //Write an extension method that appends an ‘s’ to a string.
        public static string PluralizeString(this string str)
        {
            return string.Concat(str, 's');
        }

        //Write an extension method that will capitalize a word.
        public static string CapitalizeWord(this string str)
        {
            // return string.Concat(char.ToUpper(str[0]), str.Substring(1));
            return char.ToUpper(str[0]) + str.Substring(1);
        }


        //Write an extension method what will count the number of characters in a string.
        public static int CharacterCount(this string str)
        {
            return str.Length;
        }

        //Write an extension method that will apply a VAT of 24% on an input. This input can be a decimal value, or an integer on
        public static decimal ApplyVAT(this decimal input) 
        {

            return input + input * 24 / 100;
        }

        //public static int ApplyVAT(this int input)
        //{

        //    return input + input * 24 / 100;
        //}


    }


}

