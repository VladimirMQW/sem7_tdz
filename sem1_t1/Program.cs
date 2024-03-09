// Является ли первое число квадратом 2го.
// a=25  b=5  yea
// a=2 b=10 no
// a=9 b=-3 yes
// a=-3 b=9 no

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
