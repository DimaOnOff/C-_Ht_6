// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

//Console.WriteLine("Enter massive size:");
//int size = int.Parse(Console.ReadLine());
//Console.Write($"[{String.Join(",", array)}]");

//int EnterArray (int size, int minValue, int maxValue);
//{
//    int[] result = new int [size];
//        for (int i = 0; i < size; i++)  
//        {
//            Console.WriteLine($"Enter integer {i}:");
//            Console.WriteLine("Введите {0}-й элемент", i + 1);
//            result[i] = int.Parse(Console.ReadLine());
//        }
//        return result;
//}

// Console.WriteLine("Enter 1-th numbers:");
int[] array = Enter(8);
int Count = 0;

Console.WriteLine($"[{String.Join(",", array)}]");


int[] Enter(int size)
{
    int[] array = new int[size];
        for (int i = 0; i < size; i++)  
        {
            Console.WriteLine($"Enter {i+1} number: ");
            array [i] = int.Parse(Console.ReadLine());
        }
        return array;
}


foreach (int el in array)
{
    if (el > 0)
    {
        Count++;
    }
}
Console.WriteLine ($"numbers > zero: {Count}");



//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Clear();
// Console.WriteLine("Enter b1:");
// double b1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Enter k1:");
// double k1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Enter b2:");
// double b2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Enter k2:");
// double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter throw space b1 k1 b2 k2: ");
string[] f = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
double b1 = double.Parse(f[0]);
double k1 = double.Parse(f[1]);
double b2 = double.Parse(f[2]);
double k2 = double.Parse(f[3]);

double x = (b1-b2) / (k2-k1);
double y = k2 * x + b2;
Console.WriteLine($"Two straight lines Intersection point: x={x}, y={y}");