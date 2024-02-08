int[,] CreateMatrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];

    Random rnd = new Random();
    // создадим массив рандомно
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
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

//Сумма цифр числа 
int SumOfDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int digit = number % 10;

        sum += digit;

        number /= 10;
    }
    return sum;
}


int[,] matrix = CreateMatrix(4,5);
ShowMatrix(matrix);

foreach (int elem in matrix)
{
    if(SumOfDigits(elem)%2 == 0)
            {
                System.Console.Write($"{elem} ");
            }
}
