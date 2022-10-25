// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int Length = number.Length;
// if (Length == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"{number} - это палиндром");
//     }
//     else
//     {
//         Console.WriteLine($"{number} - это не палиндром");
//     }
// }
// else
// {
//     Console.WriteLine($"Error: {number} - введённое число не пятизначное");
// }

// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// int number = ReadInt("Введите число N: ");

// for (int i = 1; i <= number; i++)
// {
//     Console.Write($"{i * i * i} ");
// }
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int dotX1 = ReadInt("Введите координату X первой точки: ");
int dotY1 = ReadInt("Введите координату Y первой точки: ");
int dotZ1 = ReadInt("Введите координату Z первой точки: ");
int dotX2 = ReadInt("Введите координату X второй точки: ");
int dotY2 = ReadInt("Введите координату Y второй точки: ");
int dotZ2 = ReadInt("Введите координату Z второй точки: ");

int A = dotX2 - dotX1;
int B = dotY2 - dotY1;
int C = dotZ2 - dotZ1;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {length}");
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}