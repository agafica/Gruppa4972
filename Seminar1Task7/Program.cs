﻿Console.WriteLine("Enter the number: ");
int num=int.Parse(Console.ReadLine()??"0");

if(num>99&&num<1000)
{
    int lastNum=num%10;
    Console.WriteLine("Последнее число "+num+" это "+lastNum);
}


