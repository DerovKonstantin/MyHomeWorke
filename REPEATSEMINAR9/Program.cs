
int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

/*
//---------------------------------------------------------------------------
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
int number = Input("Input number -> ");
NaturalNumber(number);

int NaturalNumber(int number)
{
    Console.Write(number + ", ");
    if (number == 2)
    {
        Console.WriteLine(number - 1);
        return number;
    }
    else
    {
        number = (NaturalNumber(number - 1));
        return number;
    }
    
}
//--------------------------------------------

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
int numberM = Input("Input number (M) -> ");
int numberN = Input("Input number (N) -> ");
int sum = numberM;
SumNaturalElementsIn(numberM, numberN, sum);

void SumNaturalElementsIn(int numberM, int numberN, int sum)

{
    if (numberM == numberN)
    {
        Console.WriteLine(sum);    
    }

    if (numberM < numberN)
    {
        SumNaturalElementsIn(  numberM + 1, numberN, numberM + 1 + sum);
    }
}
//----------------------------------------------------------------------
*/
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
int m = Input("Input number (m) -> ");
int n = Input("Input number (n) -> ");

Console.WriteLine(Akkerman(m, n));

int Akkerman(int m, int n)

{
    if (m == 0)
    { 
        return n+1;
    }
    if (m > 0 && n == 0)
    { 
        return Akkerman(m-1, 1);
    }
    if (m > 0 && n > 0)
    { 
        return Akkerman(m-1, Akkerman(m, n - 1));
    }
    return n;
}



