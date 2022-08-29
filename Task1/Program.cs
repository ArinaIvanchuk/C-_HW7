// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int InputData()
{
    Console.WriteLine("input number");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double[,] Matrix(int line, int column)
{
    double[,] matrix = new double[line, column];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().NextDouble()*20 - 10;
        }
    }
    return matrix;
}
void ShowArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:f1}\t");
        }
        Console.WriteLine();
    }
}
int m = InputData();
int n= InputData();
double [,] array = Matrix(m, n);
ShowArray(array);

