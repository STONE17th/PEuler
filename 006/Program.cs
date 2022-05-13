Console.WriteLine("Найдите разность между суммой квадратов и квадратом суммы первых ста натуральных чисел.");
Console.Write("Введите предел: ");
int NumberN = int.Parse(Console.ReadLine() ?? "0");
int SqSum = 0, SumSq = 0;
for (int k=1; k <= NumberN; k++)
{
    SqSum = SqSum + k;
    SumSq = SumSq + k*k;
}
Console.Write($"Разность квдарата суммы и суммы квадратов всех натуральных чисел от 1 до {NumberN} равна {SqSum*SqSum - SumSq}");