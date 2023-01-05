/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

Console.WriteLine("Задайте двумерный массив");

int coiumn_count = Convert.ToInt32(Console.ReadLine());
int row_count = Convert.ToInt32(Console.ReadLine());
Random random = new();
int GenerateRandomNumber()
{
   //Int64 temp = (Int64)int.MaxValue -(Int64)int.MinValue;
    const Int64 min_value = -100;
    const Int64 max_value = 100;
    return (int)(min_value + (max_value - min_value) * random.NextDouble()); 
}
List<List<int>> matrix = new();

for (int i = 0; i < row_count; i++)
{
    matrix.Add(new());
    for (int k = 0; k < coiumn_count; k++)
    {
        int randomNumber = GenerateRandomNumber();
        matrix[i].Add(randomNumber);

        Console.Write(randomNumber);
        Console.Write(" ");
    }
   
    Console.WriteLine();
}

List<int> sum = new();

for(int i = 0; i < row_count; i++)
 {
    sum.Add(matrix[i].Sum());
 }
 int max = sum[0];
 int Max_Sum = 0;
 for(int i = 0; i < sum.Count; i++)
 {
    if(sum[i] > max)
    {
        max = sum[i];
        Max_Sum = i;
    }
 }
 Console.WriteLine(Max_Sum);