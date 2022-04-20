// Пример задачи из семинара
void ReduceNumber()
{
    int num = new Random().Next(100,999);
    Console.Write(num + " -> ");
    int num1 = num / 100;
    int num2 = num % 10;

    Console.Write(num1);
    Console.Write(num2);
}

ReduceNumber();