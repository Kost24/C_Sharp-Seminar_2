// Задача 3: Напишите программу, которая принимает 
// на вход целое число из отрезка [10, 99] и показывает 
// наибольшую цифру числа.

System.Console.Write($"Введите целое число из отрезка [10, 99]: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9 && number < 100)
{
    if(number / 10 > number % 10)
    {
        System.Console.WriteLine($"Первая цифра больше : {number / 10} ");
    }
    else if(number / 10 < number % 10)
    {
        System.Console.WriteLine($"Вторая цифра больше : {number % 10} ");
    }
    else if(number / 10 == number % 10)
    {
        System.Console.WriteLine("Чило равны");
    }
}
else 
{
    System.Console.WriteLine("Чило введено неправильно");
}
