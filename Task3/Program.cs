//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int InputData()
{
    Console.WriteLine("input data");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] Matrix(int line, int colum, int minRand = -100, int maxRand = 100)
{
    int[,] matrix = new int[line, colum];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minRand, maxRand);
        }
    }
    return matrix;
}
void ShowArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int line = InputData();
int colum = InputData();
int [] sum = new int[colum];
int[,] array = Matrix(line, colum);
ShowArray(array);
for (int i=0; i<line; i++)
{
    for(int j=0; j<colum; j++)
    {
        sum[i] += array[j, i];
    }
}

for (int i=0; i<line; i++)
{
    double mid=0;
    mid = (double)sum[i] / colum;
    Console.Write($"mid = {mid:f1} ");
}

