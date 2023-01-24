/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

double getIntFromUser(string message)  
{
    Console.WriteLine(message);
    double userInt = int.Parse(Console.ReadLine()!);
    return userInt;
}

double b1 = getIntFromUser ("Введите значение b1 :");
double k1 = getIntFromUser ("Введите значение k1 :");
double b2 = getIntFromUser ("Введите значение b2 :");
double k2 = getIntFromUser ("Введите значение k2 :");

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {x}, Y: {y}");