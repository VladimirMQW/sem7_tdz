double CalcFormula(int a, int b, int c, int d)
{
    double num = a * b;
    int denom = c + d;
    double result = num / denom;
    //double result = a * b / (c + d);
    return result;
}

double res = CalcFormula(1, 2, 3, 4);

Console.WriteLine(res);