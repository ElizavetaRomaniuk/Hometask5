// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве
int number = 0;
int[] arrayResult = new int[8];
int[] GetArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}
static void Even (int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
        number = number + 1;
        }
    }
    Console.WriteLine(number);
}
void PrintResult(int[] array)
{
    Console.WriteLine($"Array result is {String.Join(" ", array)}");
}
arrayResult = GetArray();
PrintResult(arrayResult);
Even(arrayResult, number);