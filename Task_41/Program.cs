/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/


int getIntFromUser(string message)  
{
    Console.WriteLine(message);
    int userInt = int.Parse(Console.ReadLine()!);
    return userInt;
}

int getNum( int end)
{
    int count = 0;

for (int i = 0; i < end; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    int x = int.Parse(Console.ReadLine()!);
    if (x > 0)
        count++;
}
return count;
}

int M = getIntFromUser( "Введите количество чисел :");
int Sum = getNum(M);
Console.WriteLine($"Положительных чисел: {Sum}");
