// Задача 3: 
// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

int n;
Console.Write("Введите размер массива: ");
int.TryParse(Console.ReadLine(), out n);

Random rand = new Random();
int[] numbersArray = new int[n];
FullfilRandomIntArray(numbersArray, rand, 1, 100);
Console.WriteLine("Массив с случайными целыми числами:");
PrintArray(numbersArray);
Console.WriteLine("\nЭлементы массива в обратном порядке:");
ReversePrintArray(numbersArray, numbersArray.Length);


void FullfilRandomIntArray(int[] numbersArray, Random rand, int startRange, int endRange, int startingIndex = 0)
{
    if (startingIndex >= numbersArray.Length) return;
    if (endRange < startRange) return;

    numbersArray[startingIndex] = rand.Next(startRange, endRange);
    FullfilRandomIntArray(numbersArray, rand, startRange, endRange, startingIndex + 1);
}

void PrintArray(int[] numbersArray, int startingIndex = 0)
{
    if (startingIndex == numbersArray.Length - 1)
    {
        Console.Write($"{numbersArray[startingIndex]}");
        return;
    }
    Console.Write($"{numbersArray[startingIndex]} ");
    PrintArray(numbersArray, startingIndex + 1);
}

void ReversePrintArray(int[] numbersArray, int arraySize)
{
    if (arraySize == 1)
    {
        Console.Write($"{numbersArray[arraySize - 1]}");
        return;
    }
    Console.Write($"{numbersArray[arraySize - 1]} ");
    ReversePrintArray(numbersArray, arraySize - 1);
}