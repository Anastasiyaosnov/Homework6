// Задача 5: * Найдите максимальное значение в матрице по каждой строке,
// получите сумму этих максимумов. 
// Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

int Promt(string message)
{
    Console.WriteLine($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillMatrix(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max);
        }
    }
}


int MaxValueRaws(int[,] matrix)
{
    int sum = 0;
    int max = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        max = matrix[i, 0];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (max <= matrix[i,j])
            {
                max = matrix[i,j];
            }
        
        }
        sum += max;
    }
    return sum;
}

int MinValueColumns(int[,] matrix)
{
    int sum = 0;
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        min = matrix[0, i];
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            if (min >= matrix[j,i])
            {
                min = matrix[j,i];
            }
        
        }
        sum += min;
    }
    return sum;
}


int rows = Promt("Сколько будет в матрице строк?");
int columns = Promt("Сколько будет в матрице столбцов?");
int UserMin = Promt("Введите минимальное значение элемента матрицы");
int UserMax = Promt("Введите максимальное значение элемента матрицы");

int[,] UserMatrix = new int [rows, columns];
FillMatrix(UserMatrix, UserMin, UserMax);
PrintMatrix(UserMatrix);

int UserMaxRows = MaxValueRaws(UserMatrix);
Console.WriteLine(UserMaxRows);

int UserMinColumns = MinValueColumns(UserMatrix);
Console.WriteLine(UserMinColumns);

int Total = UserMaxRows - UserMinColumns;
Console.WriteLine($"{UserMaxRows} - {UserMinColumns} = {Total}");