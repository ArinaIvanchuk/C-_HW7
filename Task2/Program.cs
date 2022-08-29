//Напишите программу, которая на вход принимает позиции элемента в двумерном 
//массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int InputData()
{
    Console.WriteLine("input data");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] Matrix(int line, int column, int minRand = -100, int maxRand = 100)
{
    int[,] matrix = new int[line, column];
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
void Find(int[,] myArray, int line1, int column1)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            if(line1 == i && column1 == j)
            {
                System.Console.WriteLine($"the item found {myArray[i,j]}");

                return;
            }   
        }
    }
    Console.WriteLine("the item doesn't exist");

}

int line = InputData();
int column = InputData();
int [,] myArray = Matrix(line,column);
ShowArray(myArray);
int line1 = InputData();
int column1 = InputData();
Find(myArray, line1 ,column1);