// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int[] arrayResult = new int[8];
int[] GetArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 100);
    return array;
}
static void Difference (int[] array)
{
    int min = array[0];
    int maxim = array[0];
        for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
        min = array[i];
        }
        if (array[i] > maxim)
        {
        maxim = array[i];
        }
    }
    Console.WriteLine(maxim-min);
}
void PrintResult(int[] array)
{
    Console.WriteLine($"Array result is {String.Join(" ", array)}");
}
arrayResult = GetArray();
PrintResult(arrayResult);
Difference(arrayResult);