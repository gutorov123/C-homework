//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] startArray = GetArrayDouble(6, 0, 999);
Console.WriteLine(String.Join(" ", StartArrayDouble));
Console.WriteLine($"Разница = {GetDifference(StartArrayDouble)}");

double[] GetArrayDouble(int size, int minValue, int maxValue)
{
    double[] res = new double[size];
    var random = new Random();
    
    for (int i = 0; i < size; i++)
    {
        res[i] = random.Next(minValue, maxValue + 1) + random.NextDouble();
    }
    return res;
}

double GetArrayDouble(double[] array)
{
    double min = array[0];
    double max = array[0];
    foreach (var item in array)
    {
        if (min > item) min = item;
        if (max < item) max = item;
    }
    return max - min;
}