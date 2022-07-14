/*
//-----------------------------------------------------------------------------------------------------------
// Задача 73: Есть число N. Сколько групп M, можно получить при разбиении всех чисел на группы, 
// так чтобы в одной группе все числа в группе друг на друга не делились? Найдите M при заданном N и 
// получите одно из разбиений на группы N ≤ 10²⁰.

// Например, для N = 50, M получается 6
// Группа 1: 1
// Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47
// Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
// Группа 4: 8 12 18 20 27 28 30 42 44 45 50
// Группа 5: 7 16 24 36 40
// Группа 6: 5 32 48

// Группа 1: 1
// Группа 2: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
// Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
// Группа 4: 8 12 18 20 27 28 30 42 44 45 50
// Группа 5: 16 24 36 40
// Группа 6: 32 48

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void CreatArray(int[] creatArray)
{
    for (int i = 0; i < creatArray.Length; i++)
    {
        creatArray[i] = i+1;
    }
}

void PrintArray(int[] printarray)
{
    for (int i = 0; i < printarray.Length-1; i++)
    {
        Console.Write(printarray[i] + ", ");
    }
    Console.WriteLine(printarray[printarray.Length-1] + ".");
}

int[] GroupOfIndivisibleElements(int[] array)
{
    int[] newarray = new int[array.Length];
    int j = 0; // позиция элемента нового массива(группы)
    int size = 0; // финальный размер групы
    
    for (int i = 0; i < array.Length; i++) // проходим по основному массиву
    {
        if (array[i] > 0) // если значение элемента больше 0, то с этого элемента создается группа
        {
            if(newarray[0] == 0) // заполнили первый элемент в группы
            {
                newarray[j] = array[i];
                array[i] = 0;
                size++;
            }

            else  // проверяем второй элемент для заполнения
            {
                while (newarray[j] != 0) // позиция второго элемента
                {
                    j++;  
                }

                int count = 0;
                for (int c = 0; c < j; c++) // проверяем елемент в группе на деление
                {
                    if(array[i] % newarray[c] == 0)
                    count++;
                }
                    
                if(count == 0)
                { 
                    newarray[j] = array[i]; // не делится добавляем
                    array[i] = 0;
                    size++;                   
                }
            }
        }
    }

    int[] formedarray = new int[size]; // формируем получившийся массив в размер
    for (int i = 0; i < formedarray.Length; i++)
    {
        formedarray[i] = newarray[i];
    }
    return formedarray;
}

void GgroupCounter(int[] array, int countGgroup)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
            break;
        }
    }

    if(count > 0)
    {
        Console.Write("Group " + countGgroup + ": ");
        PrintArray(GroupOfIndivisibleElements(array));
        GgroupCounter(array, countGgroup + 1);
        countGgroup++;
        Console.WriteLine();
    } 
}

Console.Clear();
int size = Input("введите число -> ");
int[] array = new int[size];
CreatArray(array);
int countGgroup = 1;
GgroupCounter(array, countGgroup);
//------------------------------------
*/

// Дополнительная задача 74*: 4 друга должны посетить 12 пабов, в котором выпить по британской пинте пенного 
// напитка. До каждого бара идти примерно 15-20 минут, каждый пьет пинту за 15 минут. У первого друга лимит 
// выпитого 1.1 литра, у второго 1.5, у третьего 2.2 литра, у 4 - 3.3 литра, это их максимум. Необходимо 
// выяснить, до скольки баров смогут дойти каждый из друзей(Пройденное расстояние (в барах)), пока не упадет. 
// И сколько всего времени будет потрачено на выпивку.

int mustVisitPpubs = 12;
double britishPint = 0.57; // 0,57 литра.
int walkingTime = new Random().Next(15, 20);//до каждого бара идти примерно 15-20 минут
int onePintTime = 15;// каждый пьет пинту за 15 минут
Console.Clear();
Console.WriteLine("Варианты посещения пабов:");
Console.WriteLine("1 Все вместе,");
Console.WriteLine("2 Все по разым пабам,");
Console.WriteLine("3 Ртаспределится так чтобы посетить все 12 пабов.");
int barOptions = Input("Выберите вариант -> ");
Console.WriteLine();
 
int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

// колличество пабов
double NumberOfPubs(double drinkLimit, double britishPint)
{
    double theNumberOfPubs = drinkLimit / britishPint;
    return theNumberOfPubs;
} 

// всего времени будет потрачено на выпивку, с ходьбой
double DrinkingTime(double theNumberOfPubs, double walkingTime, double onePintTime)  
{
    double drinkingTime = theNumberOfPubs * (walkingTime + onePintTime);
    return drinkingTime;
}

// возможные варианты посещения пабов
void ReadTheOptions( double britishPint, double walkingTime, double onePintTime, int barOptions)
{
    double limitFirstFriend = 1.1; // литра
    double limitSecondFriend = 1.5; // литра
    double limitThirdFriend = 2.2; // литра
    double limitFourthFriend = 3.3; // литра

    if(barOptions == 1)
    {
        Console.WriteLine("Пошли все вместе и самый здоровый тоскал с собой всех троих на протяжении " 
        + Math.Ceiling(DrinkingTime(NumberOfPubs (limitFirstFriend, britishPint), walkingTime, onePintTime)) + " минут, ");
        Console.Write("пока сам не уснул в " + Math.Ceiling(NumberOfPubs (limitFourthFriend, britishPint)) + " пабе.");
        Console.WriteLine();
    }

    if(barOptions == 2)
    {
        double totalBar = 0;
        double totalTime = 0;
        
        totalBar = (NumberOfPubs (limitFirstFriend, britishPint)) + (NumberOfPubs (limitSecondFriend, britishPint))+
        + (NumberOfPubs (limitThirdFriend, britishPint)) + (NumberOfPubs (limitFourthFriend, britishPint));

        totalTime = DrinkingTime(NumberOfPubs (limitFirstFriend, britishPint), walkingTime, onePintTime)+
        + DrinkingTime(NumberOfPubs (limitSecondFriend, britishPint), walkingTime, onePintTime)+
        + DrinkingTime(NumberOfPubs (limitThirdFriend, britishPint), walkingTime, onePintTime)+
        + DrinkingTime(NumberOfPubs (limitFourthFriend, britishPint), walkingTime, onePintTime);

        Console.WriteLine("Все пошли по разым пабам и суммарно обошли " + Math.Ceiling(totalBar) + " пабов.");
        Console.WriteLine("Общее время похода составило " + Math.Ceiling(totalTime) + " минуту.");
    }

    if(barOptions == 3)
    {
        int totalBar = 0;
        int First = Convert.ToInt32(Math.Ceiling(NumberOfPubs (limitFirstFriend, britishPint)));
        int Second = Convert.ToInt32(Math.Ceiling(NumberOfPubs (limitSecondFriend, britishPint)));
        int Third = Convert.ToInt32(Math.Ceiling(NumberOfPubs (limitThirdFriend, britishPint)));
        int Fourth = Convert.ToInt32(Math.Ceiling(NumberOfPubs (limitFourthFriend, britishPint)));
        int[] array = {First, Second, Third, Fourth};

        // поиск лишнего друга и решение всей задачи
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if(i != j)
                {
                    totalBar += array[i];
                    if(totalBar == mustVisitPpubs)
                    {
                        Console.WriteLine("Для того чтобы напится до лимита в 12 пабах понадобится " + (array.Length -1) + " друга, " + (i+1) + " друг получается лишний. =)");
                        Console.WriteLine("Первый друг пройдет " + First + " паба, и потратит на все " + DrinkingTime(First, walkingTime, onePintTime) + " минут.");
                        Console.WriteLine("Второй друг пройдет " + Second + " паба, и потратит на все " + DrinkingTime(Second, walkingTime, onePintTime) + " минут.");
                        Console.WriteLine("Третий друг пройдет " + Third + " паба, и потратит на все " + DrinkingTime(Third, walkingTime, onePintTime) + " минут.");
                        Console.WriteLine("Четверты друг пройдет " + Fourth + " пабовб, и потратит на все " + DrinkingTime(Fourth, walkingTime, onePintTime) + " минут.");
                    }
                } 
            }
        }
    }  
}

Console.Clear();
ReadTheOptions( britishPint, walkingTime, onePintTime, barOptions);







