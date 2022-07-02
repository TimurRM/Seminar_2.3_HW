// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите координату Ax: ");
        int Ax = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите координату Ay: ");
        int Ay = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите координату Az: ");
        int Az = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите координату Bx: ");
        int Bx = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите координату By: ");
        int By = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите координату Bz: ");
        int Bz = Convert.ToInt32(Console.ReadLine());

        Console.Write("A " + (Ax,Ay,Az) + "; B" + (Bx,By,Bz) + " -> ");
        Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(Ax - Bx, 2) + Math.Pow(Ay - By, 2) + Math.Pow(Az - Bz, 2)), 2));
    }
}


// double SystemCoor(int x1, int y1, int z1, int x2, int y2, int z2){
//     return Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2) ,2) + Math.Pow((z1 - z2), 2));
// }

//                 Console.WriteLine("Введите координату x1");
//                 int Ax = Convert.ToInt32(Console.ReadLine());
//                 Console.WriteLine("Введите координату y1");
//                 int Ay = Convert.ToInt32(Console.ReadLine());
//                 Console.WriteLine("Введите координату z1");
//                 int Az = Convert.ToInt32(Console.ReadLine());
//                 Console.WriteLine("Введите координату x2");
//                 int Bx = Convert.ToInt32(Console.ReadLine());
//                 Console.WriteLine("Введите координату y2");
//                 int By = Convert.ToInt32(Console.ReadLine());
//                 Console.WriteLine("Введите координату z2");
//                 int Bz = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine(Math.Round(SystemCoor(Ax, Ay, Az, Bx, By, Bz), 2));



