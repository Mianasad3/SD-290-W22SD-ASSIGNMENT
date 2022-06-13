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


using System;  //Libarary
using System.Text;  //Namespace


    class Machine
    {

        private int DAmount;
        const int cost = 95;


        public Machine()
        {
            DAmount = 0;
        }
        public void DCoin(int coinAmount)
        {
            DAmount += coinAmount; //Increment in Damount
        }
        public void GetDrink()
        {
            if (DAmount >= cost)   //cost is greater then the if work
            {
                Console.WriteLine("Your Change is {0} cents", DAmount - cost);  //Printing
            }
            else
                Console.WriteLine("insert more coins");  //if cost is less 

        }
        public void GetRefund()
        {
            Console.WriteLine("You were refunded {0}", DAmount); //Printing
            DCoin(0);
        }


        public static void Main(string[] args)
        {
            Console.WriteLine("************ Hello from vendor Machine *************** ");//Starting
            var Machine = new Machine();
            Machine.DCoin(70);  //Pasing 70 to DCOIN
            Machine.DCoin(3);   //passing 3 to DCOIN
            Machine.GetDrink(); //calling Getdrink
            Console.ReadLine(); //calling ReadLine
        }
    }

