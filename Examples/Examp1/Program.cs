* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой
 строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

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
    matrix[i].Sort();
    matrix[i].Reverse();
    Console.WriteLine();
}

for(int i = 0; i < row_count; i++)
{
    for(int k = 0; k < coiumn_count; k++)
    {
        Console.Write(matrix[i][k]);
        Console.Write(" ");
    }
    Console.WriteLine();
}   
