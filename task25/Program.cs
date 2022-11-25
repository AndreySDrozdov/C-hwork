/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Без использования функции Math.Pow.

3, 5 -> 243 (3^5)
2, 4 -> 16
*/

Console.Write("введите число A: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число B: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());
int ToDegrees = firstnumber;

for (int i = 1; i < secondnumber; i++)
{
ToDegrees *= firstnumber;
}
Console.WriteLine("A в степени B равно: " + ToDegrees);
