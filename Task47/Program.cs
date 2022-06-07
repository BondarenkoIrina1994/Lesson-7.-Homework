// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
int CheckingForCorrectnes(string str)
{
    while (true)
    {
        Console.WriteLine(str);
        string num = Console.ReadLine();
        if (int.TryParse(num, out int number) == false)
            Console.WriteLine("Вы ввели не число. Для корректной работы программы введите число!!!");
        else
        {
            if (number <= 0)
                Console.WriteLine("Необходимо ввести число больше ноля!!!");
            else
                return number;
        }
    }
}
double[,] Array(int firstDemension, int secondDemension)
{
    double[,] array = new double[firstDemension, secondDemension];
    Random rnd = new Random();
    for (int i = 0; i < firstDemension; i++)
    {
        for (int j = 0; j < secondDemension; j++)
            array[i, j] = rnd.NextDouble();
    }
    return array;
}
void PrintArray(double[,] array)
{
    Console.WriteLine("Двумерный массив имеет следующий вид:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]:0.000} ");

        Console.WriteLine();
    }
}
int firstDemension = CheckingForCorrectnes("Введите число строк m двумерного массива:");
int secondDemension = CheckingForCorrectnes("Введите число столбцов n двумерного массима:");
double[,] ArrayResult = Array(firstDemension, secondDemension);
PrintArray(ArrayResult);