// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет, 12821 -> да , 23432 -> да


/*System.Console.WriteLine("Введите число: ");
string text = Convert.ToString(Console.ReadLine()!);


if (text.Length > 5 || text.Length < 5)
{
    System.Console.WriteLine("Ошибка, число должно быть пятизначным");
    return;
}
if (text[0] == text[4] && text[1] == text[3])
{
    System.Console.WriteLine("Число является палиндромом");
}
else 
{
    System.Console.WriteLine("Число не явяется палиндромом");
}*/
  


// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84,  A (7,-5, 0); B (1,-1,9) -> 11.53

/*System.Console.Write("Введите координату x точки A: ");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату y точки A: ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату z точки A: ");
int z1= Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату x точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату y точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату z точки B: ");
int z2= Convert.ToInt32(Console.ReadLine());

double result = Math.Round(Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2) + Math.Pow((z1-z2), 2)), 2);
System.Console.WriteLine($"Расстояние между двумя точками {result}");*/




// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27,         5 -> 1, 8, 27, 64, 125

/*System.Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i<=number; i++)
{
    System.Console.Write($"{Math.Pow(i, 3)} ");
}*/