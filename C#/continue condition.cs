using System;
public class Program
{
    public static void Main()
    {
        int i = 0;
        while (i < 10)
        {
            if (i == 4)
            {
                i++;
                continue;
            }
            Console.WriteLine(i);
            i++;
        }
    }

}