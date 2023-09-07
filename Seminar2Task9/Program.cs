// Напишите программу, которая выводит случайное число из отрезка 
// [10, 99] и показывает наибольшую цифру числа.

internal class Program
{
    private static void Main(string[] args);
    {
        void VARIANT1()
 System.Random numberGnerator = new System.Random();
        int number = numberGnerator.Next(10, 100);
        Console.WriteLine(number);

        int firstDigit = number / 10;
        int secondDigit = number % 10;

        if (firstDigit > secondDigit)
        {

            Console.WriteLine(firstDigit);
        }
        else
        {
            Console.WriteLine(secondDigit);
        }
    }
}