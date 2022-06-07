// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
int[,] Array(int firstDemension, int secondDemension)
{
    int[,] array = new int[firstDemension, secondDemension];
    Random rnd = new Random();
    for (int i = 0; i < firstDemension; i++)
    {
        for (int j = 0; j < secondDemension; j++)
            array[i, j] = rnd.Next(0, 101);
    }
    return array;
}
void PrintArray(int[,] array)
{
    Console.WriteLine("Двумерный массив имеет следующий вид:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");

        Console.WriteLine();
    }
}
void ColumnsArithmeticMean(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double result = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            result = array[i, j] + result;
        Console.WriteLine($"Среднее арифметическое {j + 1}-го столбца: {result / array.GetLength(0):0.000}");
    }

}
int firstDemension = CheckingForCorrectnes("Введите число строк m двумерного массива::");
int secondDemension = CheckingForCorrectnes("Введите число столбцов n двумерного массива:");
int[,] ArrayResult = Array(firstDemension, secondDemension);
PrintArray(ArrayResult);
ColumnsArithmeticMean(ArrayResult);