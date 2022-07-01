void palindrom()
    {
        int number = new Random().Next(10, 999999);
        int num1 = number / 10000 % 10;
        int num2 = number / 1000 % 10;
        int rev1 = number / 10 % 10;
        int rev2 = number % 10;
        int nul = number / 10000;
        
            if (nul < 1 || nul > 9){
            Console.WriteLine(number + " -> " + "Not 5-digit number");
            }
            else if  (num1 == rev2 && num2 == rev1){
            Console.WriteLine(number + " -> Yes, this is palindrom");
            }
            else{
            Console.WriteLine(number + " -> No, this is not palindrom");
            }
        }
        for (int i = 0; i < 100; i++)
        {
            palindrom();
    }