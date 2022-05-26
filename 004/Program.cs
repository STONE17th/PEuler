Console.Clear();
Console.WriteLine("Число-палиндром с обеих сторон (справа налево и слева направо) читается одинаково. Самое большое число-палиндром, полученное умножением двух двузначных чисел – 9009 = 91 * 99.");
Console.WriteLine("Найдите самый большой палиндром, полученный умножением двух трехзначных чисел.");
Console.Write("Введите число: ");
int NumberN = int.Parse(Console.ReadLine() ?? "0");

int maxPoly = 0, indX = 0, indY = 0;
for (int i = 1; i < NumberN; i++)
    for (int j = 1; j < NumberN; j++)
    {
        if (PolyNumber (i*j))
            {
                maxPoly = i*j;
                indX = i;
                indY = j;
            }
    }
Console.Write($"Максимальный палиндром при умножении трехзначных чисел"
    +$" будет число {maxPoly}, полученное при умножении {indX} и {indY}");

bool PolyNumber (int Number)
{
    int NumLen = 0;
    int FirstNumber = Number;
    int SecondNumber = Number;

    while (FirstNumber>0)
        {
            FirstNumber = FirstNumber/10;
            NumLen++;
        }

    for (int i=1; i <= NumLen; i++)
    {
        FirstNumber = FirstNumber + (SecondNumber%10)*(Convert.ToInt32(Math.Pow(10,NumLen- i)));
        SecondNumber = SecondNumber/10;
    }
    if (Number == FirstNumber)
        return (true);
    else
        return (false);
}
    


// Console.WriteLine("Число-палиндром с обеих сторон (справа налево и слева направо) читается одинаково. Самое большое число-палиндром, полученное умножением двух двузначных чисел – 9009 = 91 * 99.");
// Console.WriteLine("Найдите самый большой палиндром, полученный умножением двух трехзначных чисел.");
// Console.Write("Введите число: ");
// int NumberN = int.Parse(Console.ReadLine() ?? "0");
// int CurrentNumber = 0, MaxPoly = 0, i = 0, j = 0, k = 0, Num1 = 0, Num2 = 0;

// for (i = 1; i <= NumberN; i++)
// {
//     for (j = 1; j <= NumberN; j++)
//     {
//         int Trigger = 0, NewTrigger = 0;
//         CurrentNumber = i*j;
//         char[] NumArr = CurrentNumber.ToString().ToCharArray();
//         int Index = NumArr.Length;
//         for (k=0; k<Index/2; k++)
//         {
//             NewTrigger++;
//             if ((Index > 0) && (NumArr[k] == NumArr[Index-1-k])) Trigger++;
//         }
//         if (Trigger == NewTrigger)
//         {
//             MaxPoly = CurrentNumber;
//             Num1 = i;
//             Num2 = j;
//         }
//     }
// } 
// Console.Write($"Максимальным полученный умножением двух трехзначных чисел {MaxPoly}, это произведение {Num1} и {Num2}");