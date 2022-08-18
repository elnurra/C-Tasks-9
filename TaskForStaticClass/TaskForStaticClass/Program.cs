using System;

namespace TaskForStaticClass
{
    class Program
    {
        static void Main(string[] args)
        {  //1-2
            Console.WriteLine("Write your number that checking is Even or Odd");
            int number = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("Number is odd: " + number.isEven() + "\n Number is even: " + number.isOdd());
            //3
            Console.WriteLine("Input string that checks digits in string: ");
            string text = Console.ReadLine();           
            Console.WriteLine(text.isContainsDigit());
            //4
            Console.WriteLine("Input your text that make it capitalize: ");
            string anyword = Console.ReadLine();           
            Console.WriteLine(anyword.ToCapitalize());
            //5
            Console.WriteLine("Input your string: ");
            string word = Console.ReadLine();
            Console.WriteLine("Input your char value");
            char letter = char.Parse(Console.ReadLine());
            int[] arr = word.GetValueIndexes(letter);
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }


        }
    }
}
