/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int number = new int();
Console.WriteLine("Enter the number");
number = Convert.ToInt32(Console.ReadLine());
if(number >= 100)
{
    int cycleNumber = number;
    while (cycleNumber >= 999)
    {
        cycleNumber = cycleNumber / 10;
    }
        int thirdDigitNumber = cycleNumber % 10;
    Console.WriteLine($"for number {number} third digit is {thirdDigitNumber}");
}
else Console.WriteLine("no third digit");