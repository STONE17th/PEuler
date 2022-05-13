Console.WriteLine("Простые делители числа 13195 - это 5, 7, 13 и 29.");
Console.WriteLine("Каков самый большой делитель числа 600851475143, являющийся простым числом?");
Console.Write("Введите число: ");
int NumberN = int.Parse(Console.ReadLine() ?? "0");

int counter = 1;
int divine = 1;
int divine2 = 1;
int maxdivine = 1;
while (counter < NumberN)
{
    if ((NumberN%counter) == 0)
    {
        divine = counter;
    }
    counter++;
    int count = 1;
    while (count<divine)
    {
        if ((divine%count) == 0)
        {
            divine2 = count;
        }
        count++;  
    }
    if (divine2 == 1)
        {
            maxdivine = divine;
        }
    
}
Console.WriteLine($"Максимальным простым делителем числа {NumberN} является {maxdivine}");