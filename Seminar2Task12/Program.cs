// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число 
// некратно первому, то программа выводит остаток от деления.

int numA = int.Parse(Console.ReadLine()??"0");
int numB = int.Parse(Console.ReadLine()??"0");
if(numB%numA==0){
Console.WriteLine("First = Second");
}
else {
    Console.WriteLine("Second != First" + numB%numA);
}
