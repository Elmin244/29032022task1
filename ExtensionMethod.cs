using System;
using System.Collections.Generic;
using System.Text;

namespace _29032022task1
{
    static class ExtensionMethod
    {
        public static bool IsOdd(this int num)
        {
            if (num % 2 != 0)
                return true;

            return false;
        }
        public static bool IsEven(this int num)
        {
            if (num % 2 == 0)
                return true;
            return false;

        }
        public static bool IsContainsDigit(this string str, char Check)
        {
            foreach (var item in str)
            {
                if (item == Check)
                {
                    return true;
                }
                return false;
            }
            return true;
        }
        public static string ToCapitalize(this string text)
        {
            text = text.ToLower();
            string[] promises = text.Split(' ');
            string newtext = "";
            foreach (var promise in promises)
            {
                string newPromise = char.ToUpper(promise[] + promise.Substring(1) + " ");
                newtext = newtext + newPromise;
            }
            return newtext;
        }
        public static int [] GetValueIndexes(this string str,char letter)
        {
            int[] index = new int[0];
            for (int i = 0; i <str.Length; i++)
            {
                if (str[i] == letter) 
                {
                    Array.Resize(ref index, index.Length + 1);
                    index[index.Length - 1] = i;
                }
            }
            return index;

        }
    } 
}
