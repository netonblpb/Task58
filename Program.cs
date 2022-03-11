// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

Console.Clear();

Console.Write("Введите размер массива по Х:");
int X = int.Parse(Console.ReadLine());
Console.Write("Введите размер массива по Y:");
int Y = int.Parse(Console.ReadLine());
Random rnd = new Random();
int[,] array = new int[X, Y];
int change = 0;

void FillMass(int[,] mass)
{
    for (int i = 0; i < X; i++)
    {
        for (int j = 0; j < Y; j++)
        {
            array[i, j] = rnd.Next(10, 100);
        }
    }
}

void PrintMass(int[,] mass)
{
    for (int i = 0; i < X; i++)
    {
        for (int j = 0; j < Y; j++)
        {
            Console.Write(mass[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MassChange(int[,] mass, int temp)
{
    for (int i = 0; i < X; i++)
    {
        for (int j = i; j < Y; j++)
        {
            temp = mass[i, j];
            mass[i, j] = mass[j, i];
            mass[j, i] = temp;
        }
    }
}



if (X != Y) Console.WriteLine("Количество строк не равно количеству столбцов, обработка невозможна!");

else
{
    FillMass(array);
    PrintMass(array);
    MassChange(array, change);
    PrintMass(array);
}