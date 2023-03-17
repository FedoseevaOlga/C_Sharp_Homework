// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт какое число больше, какое меньше.
// Console.Write("Введите первое чиcло: ");
// int A = int.Parse(Console.ReadLine()!);

// Console.Write("Введите второе чиcло: ");
// int B = int.Parse(Console.ReadLine()!);

// if (A > B)
// {
    // Console.WriteLine($"Больше первое число: {A} ");
// }
// else Console.WriteLine($"Больше второе число:{B} ");

//  Задача 4. Напишите программу, которая на вход принимает три числа и выдаёт максимальное из этих чисел.

// Console.Write("Введите первое чиcло: ");
// int A = int.Parse(Console.ReadLine()!);

// Console.Write("Введите второе чиcло: ");
// int B = int.Parse(Console.ReadLine()!);

// Console.Write("Введите третье чиcло: ");
// int C = int.Parse(Console.ReadLine()!);

// int max = A;

// if(B > max) max = B;
// if(C > max) max = C;

// Console.Write($"Максимальное значение равно:{max} ");

// Задача 6. Напишите программу, которая на вход принимает число и выдаёт является ли число чётным.

// Console.Write("Введите чиcло: ");
// int N = int.Parse(Console.ReadLine()!);

// if (N%2==0)
// {
//    Console.Write("Это число чётное");
// }

// else
//   Console.Write("Это число нечётное");

//Задача 6. Напишите программу, 
//которая на вход принимает число N, а на выходе показывает все чётные числа от 1 до N.

/*Console.Write("Введите чиcло: ");
int N = int.Parse(Console.ReadLine()!);

int A = 1;
while(A < N)
{ if(A%2==0) Console.Write($"{A} ");
  A++;
} // A = A+1;clear*/

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