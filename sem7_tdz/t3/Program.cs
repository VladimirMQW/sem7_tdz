/*Задача 3: Задайте произвольный массив. Выведете его 
элементы, начиная с конца. Использовать рекурсию, не 
использовать циклы.
[1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 
*/
void PrintReverseArr(int[] array, int arrLen)
{
    if (arrLen < 0) return;
    else
    {
        Console.Write($"{array[arrLen]} ");
        PrintReverseArr(array, arrLen - 1);
    }
}
int[] arr = new int[] { 0, 1, 2, 5, 0, 10, 34 };
PrintReverseArr(arr, arr.Length - 1);
