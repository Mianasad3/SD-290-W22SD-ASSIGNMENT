using System;
namespace palindrome
{
    class Program
    {

        static void IsPalindrome(string &str)
        {
            string reverse = "";
            for (int i = str.Length - 1; i >= 0; i--) //String Reverse  
            {
                reverse += str[i].ToString();
            }
            if (reverse == str) //***********Checking whether string is palindrome or not******* 
            {
                Console.WriteLine("String is Palindrome :) \n Entered String Was {0} and reverse string is {1}", str, reverse);
            }
            else
            {
                Console.WriteLine("String is not Palindrome check it again \n ", str, reverse);
            }
            Console.ReadKey();
        }




        static void Main(string[] args)
        {
            string str;
            Console.WriteLine(" Enter string");  //input string
            str = Console.ReadLine();
            IsPalindrome(str);
        }
    }
}
    using System;  
                          
    public class DuplicateCharacters
{
    public static void Main()
    {
        void Duplicate()
        {
            String str = "restrest";
            int count;

            //Converts given string into character array  
            char[] str1 = str.ToCharArray();

            Console.WriteLine("Duplicate characters in a given string: ");
            //Counts each character present in the string  
            for (int i = 0; i < str1.Length; i++)
            {
                count = 1;
                for (int j = i + 1; j < str1.Length; j++)
                {
                    if (str1[i] == str1[j] && str1[i] != ' ')
                    {
                        count++;
                        //Set string1[j] to zero to avoid printing prreviously visited character  
                        str1[j] = '0';
                    }
                }
                //A character is considered as duplicate if count is greater than 1  
                if (count > 1 && str1[i] != '0')
                    Console.WriteLine(str1[i]);
            }
        }

        void main()
        {
            Duplicate();
        }
    }

}
