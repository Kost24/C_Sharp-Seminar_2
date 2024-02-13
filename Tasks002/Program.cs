// Задача 2: Напишите программу, которая принимает
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
// 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

System.Console.Write("Введите координаты точки Х: ");
int X = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координаты точки Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

if(X > 0 && Y > 0)
{
    System.Console.WriteLine($"Точка находится в четверти № 1 ");
}
else if(X < 0 && Y > 0)
{
    System.Console.WriteLine($"Точка находится в четверти № 2 ");
}
else if(X < 0 && Y < 0)
{
    System.Console.WriteLine($"Точка находится в четверти № 3 ");
}
else if(X > 0 && Y < 0)
{
    System.Console.WriteLine($"Точка находится в четверти № 4 ");
}
else 
{
    System.Console.WriteLine($"Точка находится на оси координат ");
}



