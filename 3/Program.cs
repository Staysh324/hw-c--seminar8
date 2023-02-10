int InputInt(string message) // метод ввода числа
{
    Console.Write(message + ":");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int[,] CreatArray(int min, int max, int stringmass, int columnmass) // метод создания массива с случайными числами
{                                                                   // случайные числа и размер массива вводятся с клавиатуры
    int[,] array = new int[stringmass, columnmass];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max);
        }
    }
    return array;
}

void PrintArray(int[,] array) // вывод массива в консоль
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}; ");
        }
    }
}


int[,] MultiplicationArrays(int[,] arrayA, int[,] arrayB) // метод перемножения массива А на массив B
{
    if (arrayA.GetLength(1) != arrayB.GetLength(0))
    {
        System.Console.WriteLine();
        System.Console.WriteLine("матрици нельзя перемножить");
        Environment.Exit( 0 );


    }
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayB.GetLength(0); k++)
            {
                arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }

    return arrayC;
}


int min = InputInt("введите минимальный порог элементов массива A");
int max = InputInt("введите максимальный порог элементов массива A");
int stringmass = InputInt("введите количество строк в создаваемом массиве A");
int columnmass = InputInt("введите количество столбцов в создаваемом массиве A");

int min2 = InputInt("введите минимальный порог элементов массива B");
int max2 = InputInt("введите максимальный порог элементов массива B");
int stringmass2 = InputInt("введите количество строк в создаваемом массиве B");
int columnmass2 = InputInt("введите количество столбцов в создаваемом массиве B");

int[,] arrayA = CreatArray(min, max, stringmass, columnmass);
int[,] arrayB = CreatArray(min2, max2, stringmass2, columnmass2);

PrintArray(arrayA);
System.Console.WriteLine();
PrintArray(arrayB);

int[,] arrayC = MultiplicationArrays(arrayA, arrayB);
System.Console.WriteLine();
System.Console.WriteLine("получившийся массив C:");
PrintArray(arrayC);