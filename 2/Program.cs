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

int FindMin(int [,] array) // метод поиска минимальной суммы из строк массива
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum+= array[0,j];
    }
    int min = sum;
var indexofmin = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i,j];
    }
    if (sum<min)
    {
        min = sum;
        indexofmin = i;
    }
}
return indexofmin;
}


int min = InputInt("введите минимальный порог элементов массива");
int max = InputInt("введите максимальный порог элементов массива");
int stringmass = InputInt("введите количество строк в создаваемом массиве");
int columnmass = InputInt("введите количество столбцов в создаваемом массиве");

int[,] array = CreatArray(min, max, stringmass, columnmass);
PrintArray(array);
System.Console.WriteLine();
int indexofmin = FindMin(array);
System.Console.WriteLine($"номер строки с минимальной суммой элементов = {indexofmin}");