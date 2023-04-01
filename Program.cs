// ДОМАШНЕЕ ЗАДАНИЕ К СЕМИНАРУ 7

//ЗАДАЧА 47. Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.

/*Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

double[,] array = GetArrayDouble(rows,columns, -10, 10);
PrintArrayDouble(array);

// Заполнение двумерного массива
double[,] GetArrayDouble(int m, int n, int minValue, int maxValue)
{
    double[,] res = new double[m,n];
    for(int i=0; i < m; i++)
    {
        for(int j=0; j < n; j++)
        {res[i, j] = Math.Round(new Random().NextDouble()+ new Random().Next(maxValue-minValue),2);}
    }
    return res;
}

void PrintArrayDouble(double[,] array)
{for(int i=0; i < array.GetLength(0); i++)
{ for(int j=0; j < array.GetLength(1); j++){
 Console.Write($"{array[i,j]} "); }
 Console.WriteLine();
 }
}*/

// ЗАДАЧА 50 Программа принимает на вход два числа, и проверяет, есть ли такая позиция в массиве.
/*Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите первое число, i= ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число, j = ");
int b = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows,columns, 0, 10);
PrintArray(array);
FindElement (array, a, b); 

void FindElement(int [,] array, int a, int b)

{ if(a > array.GetLength(0) || b > array.GetLength(1))
  Console.WriteLine("такого элемента в массиве нет ");
  else Console.WriteLine($"Такой элемент есть: {array[a,b]}");
   
}

// Заполнение двумерного массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m,n];
    for(int i=0; i < m; i++)
    {
        for(int j=0; j < n; j++)
        {res[i, j] = new Random().Next(minValue,maxValue + 1);}
    }
    return res;
}

void PrintArray(int[,] array)
{for(int i=0; i < array.GetLength(0); i++)
{ for(int j=0; j < array.GetLength(1); j++){
 Console.Write($"{array[i,j]} "); }
 Console.WriteLine();
 }

}*/

//ЗАДАЧА 52 Найти среднеарифметическое каждого столбца.
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);


int[,] array = GetArray(rows,columns, 0, 10);
PrintArray(array);
//Console.WriteLine($" Среднеарифметическое каждого столбца: {FindArithmetic(array)}"); 
Console.WriteLine($"[{String.Join(",", FindArithmetic(array))}]");
int[] FindArithmetic(int [,] array)

{  int[] res = new int[array.GetLength(0)];
   for(int j=0; j < array.GetLength(1); j++)
    {   
        int sum =0;
        for(int i=0; i < array.GetLength(0); i++)
        {sum+=array[i,j];}
        res [j]=sum/(array.GetLength(0));
    }
   return res;
}
// Заполнение двумерного массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m,n];
    for(int i=0; i < m; i++)
    {
        for(int j=0; j < n; j++)
        {res[i, j] = new Random().Next(minValue,maxValue + 1);}
    }
    return res;
}

void PrintArray(int[,] array)
{for(int i=0; i < array.GetLength(0); i++)
{ for(int j=0; j < array.GetLength(1); j++){
 Console.Write($"{array[i,j]} "); }
 Console.WriteLine();
 }

}