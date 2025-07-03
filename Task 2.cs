using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 25, 12, 45, 7, 89, 3, 56 };

        int min = numbers[0];
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number < min)
            {
                min = number;
            }
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine("Numbers: " + string.Join(", ", numbers));
        Console.WriteLine("Minimum Value: " + min);
        Console.WriteLine("Maximum Value: " + max);
    }
}

