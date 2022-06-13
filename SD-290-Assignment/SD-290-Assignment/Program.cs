

using System;  //Libarary
using System.Text;  //Namespace
namespace VendorMachine
{
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
}

