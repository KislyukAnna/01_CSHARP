// int[,] matrix = new int[3, 5];

// Random rnd = new Random();
// // создадим массив рандомно
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = rnd.Next(1, 11);
//     }
// }

// // вывод массива
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         System.Console.Write($"{matrix[i, j]} ");   //интерполяция строк
//     }
    
//     System.Console.WriteLine();
// }

// Функция создания двумерного массива с рандомными значениями
int[,] CreateMatrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];

    Random rnd = new Random();
    // создадим массив рандомно
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }       
    return matrix;
}

// функция вывода двумерного массива
void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");   //интерполяция строк
        }
        
        System.Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(4,5);
ShowMatrix(matrix);