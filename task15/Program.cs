/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет 
*/

int dayNumber = ReadInt("введи номер дня недели: ");

if (dayNumber == 1 || dayNumber == 2 || dayNumber == 3 || dayNumber == 4 || dayNumber ==5)
 {
     Console.WriteLine("не выходной");
 }
else if ( dayNumber == 6 || dayNumber == 7)
 {
    Console.WriteLine("ура, выходной");
 }
else
    {
       Console.WriteLine("в неделе всего 7 дней!"); 
    }
        
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}