using System;
public class Program
{
    public static void Main()
    {
        int asciiValue;
        int i = 0;
        for (asciiValue = 33; asciiValue <= 127; asciiValue++)
        {
            if ((i % 5) == 0)
            {
                Console.Write("\n");
            }
            Console.Write(" " + Convert.ToChar(asciiValue));
            i++;
        }
    }
}