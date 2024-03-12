// найти макс элемент массива
int[] arr = { 100, 3, 3, 7, 95, 11, 7, 77, 81, 520 };
int i = 0;
int max = arr[0];

while (i < arr.Length)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    i = i + 1;
}

Console.WriteLine(max);

max = arr[0];

for (int j = 0; j < arr.Length; j++)
{
    if (arr[j] > max)
    {
        max = arr[j];
    }
}
Console.WriteLine(max);

max = arr[0];

foreach (int e in arr)
{
    if (e > max)
    {
        max = e;
    }
}
Console.WriteLine(max);
