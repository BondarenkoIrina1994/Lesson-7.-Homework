// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
int CheckingForCorrectnes(string str)
{
    while (true)
    {
        Console.WriteLine(str);
        string num = Console.ReadLine();
        if ((int.TryParse(num, out int number) == false))
            Console.WriteLine("Вы ввели некорректное значение. Для корректной работы программы введите число!!!");
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
    Console.WriteLine("Матрица имеет следующий вид:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");

        Console.WriteLine();
    }
}
void PositionsElement(int[,] array, int i, int j)
{
    if (i <= (array.GetLength(0) + 1) && j <= (array.GetLength(1) + 1))
        Console.WriteLine($"Значение элемента [{i},{j}] в двумерном массиве равно: {array[i - 1, j - 1]} ");
    else
        Console.WriteLine("Введенной позиции элемента в двумерном массиве нет!!!");
}
int firstDemension = CheckingForCorrectnes("Введите позицию элемента строки в двумерном массиве (целое число): ");
int secondDemension = CheckingForCorrectnes("Введите позицию элемента столбца в двумерном массиве (целое число): ");
Random rnd = new Random();
int[,] ArrayResult = Array(rnd.Next(2, 10), rnd.Next(2, 10));
PrintArray(ArrayResult);
PositionsElement(ArrayResult, firstDemension, secondDemension);