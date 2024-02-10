// Задача 1: 
// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

System.Console.WriteLine("Введите число" + " ");
int N = Convert.ToInt32(Console.ReadLine());

if(N % 7 == 0 && N % 23 ==0)
{
    System.Console.Write($"Данное число {N} одновременно кратно 7 и 23");
}
 else if(N % 7 == 0 )
 {
    System.Console.Write("Число кратно только 7");
 }
 else if(N % 23 == 0)
 {
    System.Console.Write("Число кратно только 23");
 }
else
{
    System.Console.Write("Чило не кратно одновременно 7 и 23");
}
