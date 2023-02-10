

void PrintArray(int[,] array) // метод вывода массива в консоль
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


int InputInt(string message) // метод ввода числа
{
    Console.Write(message + ":");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}


bool CheckZero(int n) // метод проверки не является ли заданный размер массива 0
{
    if (n > 0)
    {
        return true;
    }
    else
    {
        System.Console.WriteLine("массив с размером 0 не может быть создан");
        System.Environment.Exit(1);
        return false;
    }
}

void Spiral(int[,] array, int n) // метод заполнения массива с размером n по спирали
{
    int i = 0;
    int j = 0;
    int value = 1;

     while (n != 0)
            {
                int k = 0;
                do { array[i, j++] = value++; } while (++k < n - 1);
                for (k = 0; k < n - 1; k++) array[i++, j] = value++;
                for (k = 0; k < n - 1; k++) array[i, j--] = value++;
                for (k = 0; k < n - 1; k++) array[i--, j] = value++;

                ++i; ++j; n = n < 2 ? 0 : n - 2;
    }
    System.Console.WriteLine();
    System.Console.WriteLine();
    System.Console.WriteLine("массив заполненный по спирали:");
    PrintArray(array);
}





int n = InputInt("введите размер массива");
int[,] array = new int[n, n];
if (CheckZero(n))
{
    System.Console.WriteLine("созданный массив");
    PrintArray(array);
    Spiral(array, n);
}