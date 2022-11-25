/*
Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран. Вывод сделать отдельным методом.

5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]
*/

int numbers = ReadInt("введи длинну массива N: ");

int[] array = new int[numbers];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,20);
    Console.Write(array[i] + " ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

