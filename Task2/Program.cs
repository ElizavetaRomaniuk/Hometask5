// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int sum = 0;
int[] arrayResult = new int[4];
int[] GetArray()
{
    int[] array = new int[4];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-20, 20);
    return array;
}
static void SumPositionNotEven (int[] array, int sum)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
        sum = sum + array[i];
        }
    }
    Console.WriteLine(sum);
}
void PrintResult(int[] array)
{
    Console.WriteLine($"Array result is {String.Join(" ", array)}");
}
arrayResult = GetArray();
PrintResult(arrayResult);
SumPositionNotEven(arrayResult, sum);