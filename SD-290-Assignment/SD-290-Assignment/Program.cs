using System;
using System.Text;



 class program
{
    static string compress(string str)
    {
        if (str == null || str == "")//if string is empty return empty
        {
            return str;
        }
        StringBuilder sb = new StringBuilder();
        char prevChar = str[0];
        int count = 1;
        for (int i = 1; i < str.Length; i++)
        {
            if (str[i] == prevChar)
            {
                count++;
            }
            else
            {
                sb.Append(prevChar); //insert char
                sb.Append(count);//insert count
                prevChar = str[i];//set previous to current char
                count = 1;
            }
        }

        sb.Append(prevChar);
        sb.Append(count);
        string result = sb.ToString();//create a string from builder

        if (result.Length >= str.Length)
        {
            return str;
        }
        return result;
    }


    static void Main(string[] args)
    {
        string exampleString = null;
        string result = compress(exampleString);
        Console.WriteLine(result);

        exampleString = "aabbcc";
        Console.WriteLine(exampleString);
        result = compress(exampleString);
        Console.WriteLine(result);

        exampleString = "aabbccc";
        Console.WriteLine(exampleString);
        result = compress(exampleString);
        Console.WriteLine(result);

        exampleString = "aabbbbbbccccccc";
        Console.WriteLine(exampleString);
        result = compress(exampleString);
        Console.WriteLine(result);
    }
}




