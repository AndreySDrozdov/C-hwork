/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

	
int number = ReadInt("введите число: ");

if (number < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else if (number > 99 && number < 1000)
{
        number = number % 10;
        Console.WriteLine(number);
}
else
{
    while(number >= 1000)
    {
        number = number / 10;
    }
    number = number % 10;
    Console.WriteLine(number);
    }
    int ReadInt(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }