// Задача1
// Является ли первое число квадратом 2го.
// a=25  b=5  yea
// a=2 b=10 no
// a=9 b=-3 yes
// a=-3 b=9 no
/*
Console.WriteLine("Введите 1е число:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2е число:");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2*num2)
{
    Console.WriteLine("Первое является квадратом второго"); 
}
else
{
    Console.WriteLine("Первое не является квадратом второго"); 
}
*/
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