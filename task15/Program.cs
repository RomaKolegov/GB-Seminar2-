/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

int numberDay = new int();
Console.WriteLine("Enter the number of the day of the week");
numberDay = Convert.ToInt32(Console.ReadLine());
if(numberDay >= 1 && numberDay <=7)
{
    if (numberDay == 6 || numberDay == 7)
    {
        Console.WriteLine("yes");
    }
    else Console.WriteLine("no");
}
else Console.WriteLine("no such day of the week");