// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.(3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125)

int Prompt(string message)
{
    System.Console.Write(message);
    string value=Console.ReadLine()!;
    int result=Convert.ToInt32(value);
    return result;
}

void GetCubes(int number)
{
    int CurrentNum=1;
    int Cube=1;

    while(CurrentNum<=number)
    {
        Cube=CurrentNum*CurrentNum*CurrentNum;
        Console.WriteLine(Cube);
        CurrentNum++;
    }
    return;
}

int N=Prompt("Введите число: ");
Console.WriteLine("Таблица кубов от единицы до введенного числа");
GetCubes(N);