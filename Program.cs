// Задача 19. Напишите программу, которая принимает на вход и проверяет
// является ли число паллиндромом. Задачу решить строковым методом.

Console.WriteLine("Введите пятизначное число");
string num = Console.ReadLine()!;
if(num.Length == 5)
{ 
  if(num[0] == num[4] && num[1] == num[3])
    {
    Console.WriteLine($" Число {num} - паллиндром");
    } 

  else {Console.WriteLine($" Число {num} - не паллиндром");}
}
else 
{
  Console.WriteLine("Введите корректное число. Данное число не пятизначное");
}

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

/*int RedInt(string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}

int[] a = new int[3];
int[] b = new int[3];

a[0] = RedInt("Введите координату Х точки А: ");
a[1] = RedInt("Введите координату Y точки A: ");
a[2] = RedInt("Введите координату Z точки A: ");
b[0] = RedInt("Введите координату Х точки B: ");
b[1] = RedInt("Введите координату Y точки В: ");
b[2] = RedInt("Введите координату Z точки В: ");

double Distance (int ax, int ay, int az, int bx, int by, int bz)
{
 return Math.Sqrt(Math.Pow(a[0]-b[0],2) + Math.Pow(a[1]-b[1],2) + Math.Pow(a[2]-b[2],2));
}

double res = Distance(a[0], a[1], a[2], b[0], b[1], b[2]);
Console.WriteLine("Расстояние между точками= " + res);*/


// Задача: 23 Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N. 3-> 1,8 5-> 1,8,27,64,125

/*int ReadInt(string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}

int N = ReadInt("Введите число: ");

for (int i=1; i<=N; i++)
{
Console.Write(Math.Pow(i,3)+ " ");

}*/