// Напишите программу, которая на вход принимает 
// два числа и выдаёт, какое число большее, а какое меньшее

int numA = int.Parse(Console.ReadLine()??"0");
int numB = int.Parse(Console.ReadLine()??"0");

if (numA > numB){

    Console.WriteLine("Число: "+ numA + " большеe" + " число: "+ numB+ " меньшее");
}

else 

Console.WriteLine("Число: "+ numB + " большее" + " Число: "+ numA + " меньшее");


