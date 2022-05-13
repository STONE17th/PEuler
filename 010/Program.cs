Console.WriteLine("Сумма простых чисел меньше 10 равна 2 + 3 + 5 + 7 = 17.");
Console.WriteLine("Найдите сумму всех простых чисел меньше двух миллионов.");
Console.Write("Введите предел: ");
var NumberN = int.Parse(Console.ReadLine() ?? "0");
var sum = 0;
for (int i = 1; i < NumberN; i = i + 2)
{
    int Trigger = 0;
    for (int j=1; j <= i; j = j + 2)
    {
        if (i%j == 0) Trigger++;
    }
    if (Trigger == 2) sum = sum + i;
}
Console.Write($"Сумма простых чисел меньше {NumberN} равна {sum+2}");