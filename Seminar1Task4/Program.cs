// Напишите программу, которая принимает на 
// вход три числа и выдаёт максимальное из этих чисел

int numA = int.Parse(Console.ReadLine()??"0");
int numB = int.Parse(Console.ReadLine()??"0");
int numC = int.Parse(Console.ReadLine()??"0");

if(numA > numB){

    Console.WriteLine("Число: "+ numA + "   максимальное");
}

else if(numB>numC){
    Console.WriteLine("Число: " + numB + " максимальное");

}
else 
    Console.WriteLine("Число: "+ numC + " максимальное");
