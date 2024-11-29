using System;

class Program
{
    static void Main(string[] args)
    {
        // Task2
        Console.Write("Введіть розмір масиву: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Random rand = new Random();

        for (int i = 0; i < n; i++)
        {
            arr[i] = rand.Next(5, 15);
        }

        Console.WriteLine("Вихідний масив:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Парні елементи та їх індекси:");
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                Console.WriteLine($"Індекс: {i}, Значення: {arr[i]}");
            }
        }
    }
}
