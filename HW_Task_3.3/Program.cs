// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Input number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write(number + " ->  ");
        // Console.WriteLine(Math.Pow(number, 3));
        if (number >= 0)
        {
            for (int current = 0; current <= number; current++)
                Console.Write(Math.Pow(current, 3) + " ");
        }
        else
        {
            for (int current = -1; current >= number; current--)
                Console.Write(Math.Pow(current, 3) + " ");
        }
    }
}