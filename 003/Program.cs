Console.Clear();
Console.WriteLine("Простые делители числа 13195 - это 5, 7, 13 и 29.");
Console.WriteLine("Каков самый большой делитель числа 600851475143, являющийся простым числом?");
Console.Write("Введите число: ");
long NumberN = long.Parse(Console.ReadLine() ?? "0");

long Number = NumberN;
int i = 2;
int multi = 0;

while(NumberN > 1)
{   
    if (NumberN%i == 0)
    {
        NumberN /= i;
        multi = i;
        i = 2;
    }
    else i++;
}
Console.WriteLine($"Макисмальныйм простым делителем числа {Number} является {multi}");