// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.(14212 -> нет; 12821 -> да; 23432 -> да)

int Prompt(string message)
{
    System.Console.Write(message);
    string value=Console.ReadLine()!;
    int result=Convert.ToInt32(value);
    return result;
}

bool ValidateNumber(int number)
{
    if(number<10000||number>99999)
    {
      Console.WriteLine("Число не пятизначное");
      return false;
    }
    return true;
}

bool IsPalindrome(int number)
{
    int a1=number/10000;
    int b1=number/1000;
    int a2=number%10;
    int b2=number/10%10;
    if(a1==a2||b1==b2)
    {
      return true;
    }
      return false;
}

int N=Prompt("Введите пятизначное число: ");
if (ValidateNumber(N))
{
    if (IsPalindrome(N))
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}