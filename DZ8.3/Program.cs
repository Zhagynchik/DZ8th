/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20 : 2 (m1n1) * 3 (n1k1) + 4 (m1n2) * 3 (n1k2)= 18   2 * 4 + 4 * 3 = 20
15 18 : 3 * 3 + 2 * 3 = 15   3 * 4 + 2 * 3 = 18

Произведением двух матриц А и В называется матрица С, элемент которой, находящийся на пересечении i-й строки и j-го столбца, 
равен сумме произведений элементов i-й строки матрицы А на соответствующие (по порядку) элементы j-го столбца матрицы В.

Произведение двух матриц АВ имеет смысл только в том случае, когда число столбцов матрицы А совпадает с числом строк матрицы В .
m- строки №1
n - столбцы №1 и строки №2
k - столбцы №2
В произведении матриц АВ число строк равно числу строк матрицы А , а число столбцов равно числу столбцов матрицы В .   */

Console.WriteLine("Введите размеры матрицы №1");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] firstarray = new int[m, n];
 
for (int i = 0; i < firstarray.GetLength(0); i++) 
{
    for (int j = 0; j < firstarray.GetLength(1); j++)
    {
        firstarray [i, j] = Convert.ToInt32(new Random().Next(0,10));  
        Console.Write($"{firstarray[i, j]} ");
    }
        Console.WriteLine();
}
Console.WriteLine("Введите число столбцов матрицы №2");
int k = Convert.ToInt32(Console.ReadLine());
int[,] secondarray = new int[n, k];
 
for (int i = 0; i < secondarray.GetLength(0); i++) 
{
    for (int j = 0; j < secondarray.GetLength(1); j++)
    {
        secondarray [i, j] = Convert.ToInt32(new Random().Next(0,10));  
        Console.Write($"{secondarray[i, j]} ");
    }
        Console.WriteLine();
}
Console.WriteLine("Результирующая матрица:");

int[,] resultarray = new int[m,k];

for (int i = 0; i < resultarray.GetLength(0); i++)
  {
    for (int j = 0; j < resultarray.GetLength(1); j++)
    {
      int sum = 0;
      for (int p = 0; p < firstarray.GetLength(1); p++)
      {
        sum += firstarray[i,p] * secondarray[p,j];
      }
      Console.Write($"{resultarray[i,j] = sum} ");
    }
    Console.WriteLine();
  }

