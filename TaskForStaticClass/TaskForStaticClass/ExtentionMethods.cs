using System;
using System.Collections.Generic;
using System.Text;

namespace TaskForStaticClass
{
    static class ExtentionMethods
    {
        public static bool isOdd(this int number) 
        {
            if (number%2!=0)
            {
                return true;
            }
            return false;
        }
        public static bool isEven(this int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }
        public static bool isContainsDigit(this string anynumber)
        {
            foreach (char item in anynumber)
            {
                if (char.IsDigit(item))
                {
                    return true;
                }

            }
            return false;
        }
        public static string ToCapitalize(this string anyword)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(char.ToUpper(anyword[0]));
            sb.Append(anyword.Substring(1).ToLower());
            return sb.ToString();
        }
        public static int[] GetValueIndexes(this string words,char letter)
        {
            int count = 0;
            int[] indexes = new int[0];
            
            StringBuilder sb = new StringBuilder();
            int i = 0;
            for (i = 0; i < words.Length; i++)
            {
                if (letter == words[i])
                {
                    count++;
                    Array.Resize(ref indexes, count);
                    indexes[count - 1] = i;
                    
                }
                
            }
            return indexes;
        }
        

        


    }
}
