Console.WriteLine("Задание. Если выписать все натуральные числа меньше 10, кратные 3 или 5, то получим 3, 5, 6 и 9. Сумма этих чисел равна 23.");
Console.WriteLine("Найдите сумму всех чисел меньше 1000, кратных 3 или 5.");
Console.Write("Введите верхний предел числового ряда:");
int NumberN = int.Parse(Console.ReadLine() ?? "0");
int counter = 1;
int sum = 0;
while (counter < NumberN)
{
    if (counter%3 == 0 || counter%5 == 0)
        sum = sum + counter;
    counter++;
}
Console.Write($"Сумма чисел от 1 до {NumberN} равна {sum}");