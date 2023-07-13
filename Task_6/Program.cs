/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int evenNum = number % 2;

if (evenNum == 0)
{
    Console.Write($"{number} является четным числом");
}

else
{
    Console.Write($"{number} НЕ является четным числом");
}