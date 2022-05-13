Console.WriteLine("2520 - самое маленькое число, которое делится без остатка на все числа от 1 до 10.");
Console.WriteLine("Какое самое маленькое число делится нацело на все числа от 1 до 20?");
Console.Write("Введите предел: ");
int NumberN = int.Parse(Console.ReadLine() ?? "0");

for (int j = NumberN*NumberN; ; j = j + NumberN)
{
    int Trigger = 0;
    for (int k=1; k <= NumberN; k++)
    {
        if (j%k == 0) Trigger++;
    }
    if (Trigger == NumberN)
    {
        Console.Write($"{j}");
        break;
    }
}