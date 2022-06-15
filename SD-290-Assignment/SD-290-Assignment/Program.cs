using System;

{
    static void FREQ(String str, int SIZE)
    {
        // size of the string 'str'
        int n = str.Length;
        int[] freq = new int[SIZE];
        for (int i = 0; i < n; i++)
            freq[str[i] - 'a']++;
        // traverse 'str' from left to right
        for (int i = 0; i < n; i++)
        {
            if (freq[str[i] - 'a'] != 0)
            {
                // print the character along with its
                // frequency
                Console.Write(str[i]);
                Console.Write(freq[str[i] - 'a'] + " ");
                // printed again
                freq[str[i] - 'a'] = 0;
            }
        }
    }
    public static void Main()
    {
        int SIZE = 0;
        Console.Write("Enter number of size ");
        SIZE = Convert.ToInt32(Console.ReadLine());
        string[] arr = new string[SIZE];
        int i;
        Console.Write("Read and Print elements of an array:\n");
        Console.Write("Input elements of \n", SIZE);
        for (i = 0; i < SIZE; i++)
        {
            Console.Write("element - {0} : ", i);
            arr[i] = Console.ReadLine();
        }
        Console.Write("\nElements in array are: ");
        for (i = 0; i < 10; i++)
        {
            Console.Write("{0}  ", arr[i]);
        }
        Console.Write("\n");
        FREQ(arr, SIZE);
    }
}