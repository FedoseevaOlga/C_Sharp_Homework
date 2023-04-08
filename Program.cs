//ДОМАШНЕЕ ЗАДАНИЕ К СЕМИНАРУ 8
//ЗАДАЧА 54. Задайте двумерный массив размером, упорядочите по убыванию элементы каждой строки.

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows,columns, 0, 10);
PrintArray(array);
Console.WriteLine();

int[,] newArray = Decrease(array);
PrintArray(newArray);

int [,]  Decrease(int[,] array)
{
for(int i=0; i < array.GetLength(0); i++)
{   
   
    int temp = 0;
    for(int j=0; j < array.GetLength(1); j++)
    {   
            int max = array[i,j];
            int imax = j;
        for(int k=j; k < array.GetLength(1); k++)
        {   
           
            if(array[i,k]>max) 
            {  
                max=array[i,k];
                imax=k;
            }
        }
        //if(i==1) Console.WriteLine($"j={j}; max= {max}; imax= {imax}");
        temp=array[i,j];
        array[i,j] = max;
        array[i,imax] =temp;
       //if(i==1) PrintArray(array);
    }

} return array;
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

//ЗАДАЧА 58. Задать и перемножить две матрицы.
/*Console.Write("Введите количество строк первой матрицы: ");
int rows1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов первой матрицы: ");
int columns1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество строк второй матрицы: ");
int rows2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов второй матрицы: ");
int columns2 = int.Parse(Console.ReadLine()!);

int[,] array1 = GetArray(rows1,columns1, 0, 10);
PrintArray(array1);
int[,] array2 = GetArray(rows2,columns2, 0, 10);
PrintArray(array2);
PrintArray(Multiplay(array1,array2));

int[,] Multiplay(int[,] matrix1, int[,] matrix2)
{   
    int [,] result = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
     if(matrix1.GetLength(0)!=matrix2.GetLength(1)) 
    {Console.WriteLine("Матрицы нельзя перемножить. Количество строк первого множителя должно совпадать с количеством столбцов второго");}
    else
    {
    for(int i=0; i < matrix1.GetLength(0); i++)
       {
       for(int j=0; j < matrix2.GetLength(1); j++)
          { for(int k=0; k < matrix2.GetLength(0); k++)
              {
              result[i,j]+= matrix1[i,k]*matrix2[k,j];
              }
           }
        }  
    }
    return result;
}

//Заполнение двумерного массива
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
