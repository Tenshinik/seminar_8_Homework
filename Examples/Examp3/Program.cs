//* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая 
будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int lenght_count = 2;
int width_count = 2;
int depth_count = 2;
Random random = new();
int GenerateRandomNumber()
{
   //Int64 temp = (Int64)int.MaxValue -(Int64)int.MinValue;
    const Int64 min_value = -100;
    const Int64 max_value = 100;
    return (int)(min_value + (max_value - min_value) * random.NextDouble()); 
}
List<List<List<int>>> cube = new();

for (int i = 0; i < lenght_count; i++)
{
    cube.Add(new());
    for (int k = 0; k < width_count; k++)
    {
        cube[i].Add(new());
        for (int j = 0; j < depth_count; j++)
        {
            int randomNumber = GenerateRandomNumber();
            cube[i][k].Add(randomNumber);

            Console.Write(randomNumber);
            Console.Write("(");
            Console.Write(i);
            Console.Write(",");
            Console.Write(k);
            Console.Write(",");
            Console.Write(j);
            Console.WriteLine(")");
        }
        
    }

}