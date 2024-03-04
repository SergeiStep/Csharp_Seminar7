// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void Main()
{
    int firstNumber = ReadInt("Введите число M: ");
    int secondNumber = ReadInt("Введите число N: ");
    System.Console.WriteLine($"Числа от {firstNumber} до {secondNumber} => {ShowDigit(firstNumber, secondNumber)}");
}

string ShowDigit(int firstDigit, int secondDigit)
{
    if (firstDigit > secondDigit)
    {
        return "";
    }

    return $"{firstDigit} " + ShowDigit(firstDigit + 1, secondDigit);
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

Main();





