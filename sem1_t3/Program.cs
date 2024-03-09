//Задача3
//Принимаем 3хзначное целое число и показываем сумму 1й и последней цифры
// 456  -- 10
// 782 -- 9
//918 -- 17


Console.WriteLine("Введите целое 3хЗначное число:");
int num = Convert.ToInt32(Console.ReadLine());

if ((num >= 100 && num <= 999) || (num >= -999 && num <= -100))
{
    int digitFirst = num / 100;
    int digitLast = num % 10;
    int sum = digitFirst + digitLast;
    Console.WriteLine("Сумма: " + sum);
}
else
{
    Console.WriteLine("Некорректный ввод");
}