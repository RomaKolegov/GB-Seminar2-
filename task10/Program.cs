/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int number = new int();
Console.WriteLine("Enter a three digit number");
number = Convert.ToInt32(Console.ReadLine());
int newNumber = number % 100 / 10;
Console.WriteLine($"For a three digit number {number} second digit will be {newNumber}");