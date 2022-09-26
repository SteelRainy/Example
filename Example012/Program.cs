//Alt + Shift +F = Выровнить код.
// ??"" - Что бы не было нуля.

//Ввод
int ReaderData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

//Нахождение третьего символа.
char ThirdNumChar(string inputNumber)
{
    char[] simbols = inputNumber.ToCharArray();
    return simbols[2];
}


int ThirdNumInt(int number)
{
    int lenNum = (int)Math.Log10(number);
    int outNumber = (int)(number / Math.Pow(10, lenNum - 2)) % 10;
    return outNumber;
}


//Вывод
void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

//Программ.
int number = ReaderData("Введите число: ");
if (number < 100)
{
    PrintData("Такой цифры нет", "");
}
else
{
    char thirdSimbol = ThirdNumChar(number.ToString());
    PrintData("Введеное вами число: ", thirdSimbol.ToString());

    int thirdSimbolInt = ThirdNumInt(number);
    PrintData("Введеное вами число: ", thirdSimbolInt.ToString());
}

