//Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

using System;

public class Program
{
    public static void Main()
    {
        int[] numbers = { 1, 2, 3, 5, 4, 6, 4, 73, 8, 3 };
        ReversePrint(numbers);
    }

    public static void ReversePrint(int[] numbers)
    {
        if (numbers.Length == 1)
        {
            Console.WriteLine(numbers[0]);
            return;
        }

        int lastIndex = numbers.Length - 1;
        int firstIndex = 0;

        while (lastIndex >= firstIndex)
        {
            int temp = numbers[firstIndex];
            numbers[firstIndex] = numbers[lastIndex];
            numbers[lastIndex] = temp;

            lastIndex--;
            firstIndex++;
        }

        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}