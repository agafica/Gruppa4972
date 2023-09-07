// Напишите программу, которая принимает на вход число
//  и проверяет, кратно ли оно одновременно 7 и 23
int number = int.Parse(Console.ReadLine()??"0");

Console.WriteLine(number%7==0&&number%23==0);

