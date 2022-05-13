Console.WriteLine("Выписав первые шесть простых чисел, получим 2, 3, 5, 7, 11 и 13. Очевидно, что 6-е простое число - 13.");
Console.WriteLine("Какое число является 10001-м простым числом?");
Console.Write("Введите искомый порядковыый номер простого числа: ");
int NumberN = int.Parse(Console.ReadLine() ?? "0");
int counter = 1;
for (int i=-1; ; i = i + 2)
{
    int Trigger = 0;
    for (int j=1; j <= i; j++)
    {
        if (i%j == 0) Trigger++;
    }
    if (Trigger == 2) counter++;
    if (counter == NumberN)
    {
        Console.Write($"{i} простое число с порядковым номером {counter}");
        break;
    }
}