Console.Clear();
Console.WriteLine($"Задача Эйлера 049");

bool SimpleDigit (int number)
{
    for (int i=3; i<number; i += 2)
        if (number%i == 0)
            return(false);
    return(true);
}

int[] DigitsDev(int Number)
{
    int ind = 0;
    int[] DigitsCur = new int[4];
    while (Number>0)
    {
        DigitsCur[ind] = Number%10;
        Number /= 10;
        ind++;
    }
    Array.Sort(DigitsCur);
    return (DigitsCur);
}

bool DigitCompar(int Number1, int Number2)
{
    int ind = 0;
    bool trigger = true;
    int[] arrCur = DigitsDev(Number1);
    int[] arrNxt = DigitsDev(Number2);
    while (trigger && ind<4)
    {   
        if ((arrCur[ind]) != (arrNxt[ind]))
        {
            trigger = false;
        }
        ind++;
    }
    return (trigger);
}

List<int> SimDig = new List<int>();
int listSize = 0;

for (int i = 999; i<10000; i += 2)
    if (SimpleDigit(i))
    {
        SimDig.Add(i);
        listSize++;
    }

for (int i=0; i<listSize; i++)
{
    for (int j=i+1; j<listSize-1; j++)
    {
        if (DigitCompar(SimDig[i], SimDig[j]))
        {
            int digNxt = 2*SimDig[j] - SimDig[i];
            if (digNxt<10000 && SimpleDigit(digNxt) && DigitCompar(SimDig[i], digNxt))
                Console.WriteLine($"Нашли числа {SimDig[i]} {SimDig[j]} {digNxt}");
        }
    }
}