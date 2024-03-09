// Задача2
//Принимаем целое число N и показываем все целые от -N до N.
// 4  -4, -3, -2, -1, 0, 1, 2, 3, 4


Console.WriteLine("Введите целое положительное число:");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0)
{
    int i = -n;
    while (i <= n)
    {
        Console.Write(i + ", ");
        i = i + 1;
    }
}
else
{
    Console.WriteLine("Некорректный ввод");
}