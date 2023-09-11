double NumberOfRolls = 0;

double Red = 0;
double Black = 0;
double Green = 0;

double Even = 0;
double Odd = 0;

double[] Numbers = new double[36];
double B1_18 = 0, B19_36 = 0, B1_12 = 0, B13_24 = 0, B25_36 = 0;

Random rnd = new Random();
int times = 0;

while (NumberOfRolls < 100000000)//play x times
{
    NumberOfRolls++;
    times++;

    if(times == 1000000)//report every x times
    {
        Console.WriteLine("try: " + NumberOfRolls.ToString("#,###"));
        times = 0;
    }

    int number = rnd.Next(0, 38);

    if(number != 0 && number != 37)
    {
        Numbers[number - 1]++;
        if (number % 2 == 0)
            Even++;
        else
            Odd++;
    }

    switch (number)
    {
        case 0://0
            Green++;
            break;
        case 1:
            B1_12++;
            B1_18++;
            Red++;
            break;
        case 2:
            B1_12++;
            B1_18++;
            Black++;
            break;
        case 3:
            B1_12++;
            B1_18++;
            Red++;
            break;
        case 4:
            B1_12++;
            B1_18++;
            Black++;
            break;
        case 5:
            B1_12++;
            B1_18++;
            Red++;
            break;
        case 6:
            B1_12++;
            B1_18++;
            Black++;
            break;
        case 7:
            B1_12++;
            B1_18++;
            Red++;
            break;
        case 8:
            B1_12++;
            B1_18++;
            Black++;
            break;
        case 9:
            B1_12++;
            B1_18++;
            Red++;
            break;
        case 10:
            B1_12++;
            B1_18++;
            Black++;
            break;
        case 11:
            B1_12++;
            B1_18++;
            Black++;
            break;
        case 12:
            B1_12++;
            B1_18++;
            Red++;
            break;
        case 13:
            B13_24++;
            B1_18++;
            Black++;
            break;
        case 14:
            B13_24++;
            B1_18++;
            Red++;
            break;
        case 15:
            B13_24++;
            B1_18++;
            Black++;
            break;
        case 16:
            B13_24++;
            B1_18++;
            Red++;
            break;
        case 17:
            B13_24++;
            B1_18++;
            Black++;
            break;
        case 18:
            B13_24++;
            B1_18++;
            Red++;
            break;
        case 19:
            B13_24++;
            B19_36++;
            Red++;
            break;
        case 20:
            B13_24++;
            B19_36++;
            Black++;
            break;
        case 21:
            B13_24++;
            B19_36++;
            Red++;
            break;
        case 22:
            B13_24++;
            B19_36++;
            Black++;
            break;
        case 23:
            B13_24++;
            B19_36++;
            Red++;
            break;
        case 24:
            B13_24++;
            B19_36++;
            Black++;
            break;
        case 25:
            B25_36++;
            B19_36++;
            Red++;
            break;
        case 26:
            B25_36++;
            B19_36++;
            Black++;
            break;
        case 27:
            B25_36++;
            B19_36++;
            Red++;
            break;
        case 28:
            B25_36++;
            B19_36++;
            Black++;
            break;
        case 29:
            B25_36++;
            B19_36++;
            Black++;
            break;
        case 30:
            B25_36++;
            B19_36++;
            Red++;
            break;
        case 31:
            B25_36++;
            B19_36++;
            Black++;
            break;
        case 32:
            B25_36++;
            B19_36++;
            Red++;
            break;
        case 33:
            B25_36++;
            B19_36++;
            Black++;
            break;
        case 34:
            B25_36++;
            B19_36++;
            Red++;
            break;
        case 35:
            B25_36++;
            B19_36++;
            Black++;
            break;
        case 36:
            B25_36++;
            B19_36++;
            Red++;
            break;
        case 37://00
            Green++;
            break;
    }
}

Console.WriteLine("Number between 01-18: " + Percentage(B1_18, NumberOfRolls));
Console.WriteLine("Number between 19-36: " + Percentage(B19_36, NumberOfRolls));
Console.WriteLine("Number between 01-12: " + Percentage(B1_12, NumberOfRolls));
Console.WriteLine("Number between 13-24: " + Percentage(B13_24, NumberOfRolls));
Console.WriteLine("Number between 25-36: " + Percentage(B25_36, NumberOfRolls));

Console.WriteLine("Red: " + Percentage(Red, NumberOfRolls));
Console.WriteLine("Black: " + Percentage(Black, NumberOfRolls));
Console.WriteLine("Green: " + Percentage(Green, NumberOfRolls));

Console.WriteLine("Even: " + Percentage(Even, NumberOfRolls));
Console.WriteLine("Odd: " + Percentage(Odd, NumberOfRolls));

int i = 0;
foreach (double number in Numbers)
{
    i++;
    Console.WriteLine("Number " + i +": " + ((number / NumberOfRolls) * 100).ToString("F6") + "%");
}
string Percentage(double Number, double Total)
{
    return ((Number / Total) * 100d).ToString("F6") + "%";
}