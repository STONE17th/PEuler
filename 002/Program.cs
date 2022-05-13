Console.WriteLine("Каждый следующий элемент ряда Фибоначчи получается при сложении двух предыдущих. Начиная с 1 и 2, первые 10 элементов будут: 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...");
Console.WriteLine("Найдите сумму всех четных элементов ряда Фибоначчи, которые не превышают четыре миллиона.");
Console.Write("Введите верхний предел числового ряда:");
int NumberN = int.Parse(Console.ReadLine() ?? "0");
int sum = 0;
int NumFib1 = 0;
int NumFib2 = 1;
while(NumFib1 + NumFib2 <= NumberN)
{
    if ((NumFib1 + NumFib2)%2 == 0)
    {
        sum = sum + NumFib1 + NumFib2;
    }
    NumFib2 = NumFib1 + NumFib2;
    NumFib1 = NumFib2 - NumFib1;
}
Console.WriteLine($"Сумма всех четных чисел в последовательности Фибоначчи с последним числом {NumFib2} равна {sum}");