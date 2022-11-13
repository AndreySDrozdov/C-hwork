/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

*/

Console.Write("enter number: ");
int a = Convert.ToInt32(Console.ReadLine());

int b = a % 2;
 
if (b==1)
{
    Console.WriteLine("no");
}
else 
{
    Console.WriteLine("yes");
}




