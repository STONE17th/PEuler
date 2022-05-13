Console.WriteLine("Существует только одна тройка Пифагора, для которой a + b + c = 1000.");
Console.WriteLine("Найдите произведение abc.");
Console.Write("Введите число: ");
int NumberN = int.Parse(Console.ReadLine() ?? "0");
for(int a=1; a < NumberN ;a++)
{
    for(int b=1; b < NumberN ;b++)
    {
        for(int c=1; c < NumberN ;c++)
        {
            if ((a<b) && (b<c) && (a + b + c == NumberN) && (a*a + b*b == c*c))
            {
               Console.WriteLine($"Произведение Тройки Пифагора: {a*b*c},");
               Console.WriteLine($"где a - {a}, b - {b} и c - {c}");
               break;
            }
        }
    }
}
