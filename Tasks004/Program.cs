
// Задача 4: Напишите программу, которая на вход 
// принимает натуральное число N, а на выходе 
// показывает его цифры через запятую.


System.Console.Write("Введите число : ");
long n = Convert.ToInt32(Console.ReadLine());

System.Console.Write(n % 10 + ", ");
while((n /= 10) !=0)
System.Console.Write(n % 10 + ", ");

