using System;

{
    static Dictionary<char, int> occurrences = new Dictionary<char, int>();
    public int GetNumberInput()
    {
        int size;
        Console.WriteLine("Enter your size of int array:");
        size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            string intArray = ReadLine();
            int g = Convert.ToInt32(intArray);
            arr[i] = g;
        }
        return arr;
    }
    public char getCharacterInput()
    {
        int size;
        Console.WriteLine("Enter your size of char array:");
        size = Convert.ToInt32(Console.ReadLine());
        char[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = Console.ReadLine();
        }
        return arr;
    }
    public int countchar()
    {
        int size; int count = 0;
        Console.WriteLine("Enter your size of char array:");
        size = Convert.ToInt32(Console.ReadLine());
        char[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = Console.ReadLine();
            count++;
        }
        return count;
    }


    static void charFuction(char[] characters)
    {
        foreach (char c in characters)
        {
            if (occurrences.ContainsKey(c))
            {
                occurrences[c]++;
            }
            else
            {
                occurrences.Add(c, 1);
            }
        }
        foreach (char k in occurrences.Keys)
        {
            Console.WriteLine(k + " - " + occurrences[k]);
        }
    }

    void PrintResults(char countedCharacter, int charFrequency,, int totalChars)
    {
        Console.WriteLine(countedCharacter);
        Console.WriteLine(charFrequency);
        Console.WriteLine(totalCharas);
    }
    static void Main(string[] args)
    {
        char countedCharacter = charFuction();
        int totalChars = countchar();
        int charFrequency = getCharacterInput();
        PrintREsults(countedCharacter, charFrequency, totalChars);

    }
}
