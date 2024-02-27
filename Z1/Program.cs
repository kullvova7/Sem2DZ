// Напишите программу, 
// которая принимает на вход число и проверяет,
//  кратно ли оно одновременно 7 и 23.

System.Console.WriteLine("Введите чисо:");
int number = Convert.ToInt32(Console.ReadLine());

int a = 7;
int b = 23;

if (number % a == 0 && number % b ==0 ) 
{
Console.WriteLine("Кратное число");
}
else
{
Console.WriteLine("Число не кратно");
}