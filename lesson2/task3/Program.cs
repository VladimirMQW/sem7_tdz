int[] arr = { 1, 3, 3, 7, 5, 11, 7, 77, 81, 52 };
int i = 0;
while (i < arr.Length)
{
    if (arr[i] % 2 == 0)
        Console.Write($"{arr[i]} ");
    i = i + 1;
}
