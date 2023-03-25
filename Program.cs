// ДОМАШНЕЕ ЗАДАНИЕ №5

// ЗАДАЧА 1 Задайте массив, заполненный случайнымии положительными трёхзначными числами.
// напишите программу, которая покажет кол-во чётных чисел в массие.
//[345,897,568,234]->2

int[] array = GetRandomArray(5, 100, 1000);
Console.WriteLine($"[{String.Join(",", array)}]");

// МЕТОД РАСЧЁТА КОЛ-ВА ЧЁТНЫХ ЧИСЕЛ

int countEven(int[] mas)
{
    int count = 0;
    foreach(int el in mas)
    {count += el%2 == 0 ? 1 : 0;}
    return count;
}
Console.WriteLine($"Количество чётных чисел в массиве: {countEven(array)}");

// МЕТОД ЗАДАНИЯ МАССИВА
int[] GetRandomArray(int size, int minValue, int maxValue)

            {
                int[] result = new int[size];

                for (int i = 0; i < size; i++)

                {
                    result[i] = new Random().Next(minValue, maxValue + 1);

                }
                return result;

            }

// ЗАДАЧА 2 Задайте одномерный массив, заполненный случайнымии числами.
// Найдите сумму элементов, стоящих на нечётных индексах
//[3,7,23,12]->19

/*int[] array = GetRandomArray(5, -50, 100);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine($"Сумма нечетных элементов {oddSum(array)}");

// МЕТОД РАСЧЁТА СУММЫ НЕЧЁТНЫХ ЧИСЕЛ

int oddSum(int[] mas)
{
int Sum = 0;
for(int i = 0; i < mas.Length; i++)
    {
if(i%2 != 0) 
     {Sum += mas[i];}

    } return Sum;
}

// МЕТОД ЗАДАНИЯ МАССИВА
int[] GetRandomArray(int size, int minValue, int maxValue)

            {
                int[] result = new int[size];

                for (int i = 0; i < size; i++)

                {
                    result[i] = new Random().Next(minValue, maxValue + 1);

                }
                return result;
            } */

/* ЗАДАЧА 3 Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементом массива.

// МЕТОД ЗАДАНИЯ МАССИВА ВЕЩЕСТВЕННЫХ ЧИСЕЛ
double[] array = GetRandomDoubleArray(5, 5, 10);
Console.WriteLine($"[{String.Join(",  ",   array)}]");
Console.WriteLine($" Разница между максимальным и минимальным значениями равна: {Differ(array)}");

// МЕТОД РАСЧЁТА РАЗНИЦЫ

double Differ(double[] mas)
 {double max = mas[0];
  double min = mas[0];
  for(int i = 1; i < mas.Length; i++)
    { if(mas[i]>max) max=mas[i];
      if(mas[i]<min) min=mas[i];
    }
    
    return max-min;
}
// МЕТОД ЗАДАНИЯ МАССИВА
double[] GetRandomDoubleArray(int size, double minValue, double maxValue)
            {
                double[] result = new double[size];
                Random rand = new Random();
                for (int i = 0; i < size; i++)
                {
                    result[i] = rand.NextDouble()*10;
                }
              return result;
            } */