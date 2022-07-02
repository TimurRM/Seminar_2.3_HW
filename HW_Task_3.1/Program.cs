// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

internal class Program
{
    private static void Main(string[] args)
    {
            Console.Write("Input 1-st 5-digit number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input 2-nd 5-digit number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input 3-rd 5-digit number: ");
            int number3 = Convert.ToInt32(Console.ReadLine());
           
                if (number1 / 10000 < 1 || number1 / 10000 > 9){
                    Console.WriteLine(number1 + " -> " + "Please, input only 5-digit positive number");
                }
                else if (number1 / 10000 % 10 == number1 % 10 && number1 / 1000 % 10 == number1 / 10 % 10){
                    Console.WriteLine(number1 + " -> Yes, this is palindrom");
                }
                else{
                    Console.WriteLine(number1 + " -> No, this is not palindrom");
                }
                

                    if (number2 / 10000 < 1 || number2 / 10000 > 9){
                        Console.WriteLine(number2 + " -> " + "Please, input only 5-digit positive number");

                    }
                    else if (number2 / 10000 % 10 == number2 % 10 && number2 / 1000 % 10 == number2 / 10 % 10){
                        Console.WriteLine(number2 + " -> Yes, this is palindrom");
                    }
                    else{
                        Console.WriteLine(number2 + " -> No, this is not palindrom");
                    }


                        if (number3 / 10000 < 1 || number3 / 10000 > 9){
                            Console.WriteLine(number3 + " -> " + "Please, input only 5-digit positive number");
                        }
                        else if (number3 / 10000 % 10 == number3 % 10 && number3 / 1000 % 10 == number3 / 10 % 10){
                            Console.WriteLine(number3 + " -> Yes, this is palindrom");
                        }
                        else{
                            Console.WriteLine(number3 + " -> No, this is not palindrom");
                        }
    }
}