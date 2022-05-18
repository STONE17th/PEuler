Console.WriteLine("Программа для определения простого числа");
Console.Write("Введите число: ");
long NumberN = long.Parse(Console.ReadLine() ?? "0");

bool SimpDig (long Number)
{
    int counter = 0;
    bool simple = false;
    for (int div = 1; div <= Number; div += 2)
    if (Number%div == 0)
        counter++;
    if (counter == 2)
        simple = true;
    return (simple);
}

bool isSimple(long value)
{
    for (int i = 2; i < value; i++)
        if(value%i == 0)
            return(false);
    return(true);
}
            