// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Prompt(string message)
{
    System.Console.Write(message);
    string value=Console.ReadLine()!;
    double result=Convert.ToInt32(value);
    return result;
}

double FindLength (double Xa, double Ya, double Za, double Xb, double Yb, double Zb)
{
    double result=Math.Round(Math.Sqrt(Math.Pow((Xb-Xa),2) + Math.Pow((Yb-Ya),2) + Math.Pow((Zb-Za),2)),2);
    return result;
}

double x1=Prompt("Введите координату X первой точки:");
double y1=Prompt("Введите координату Y первой точки:");
double z1=Prompt("Введите координату Z первой точки:");
double x2=Prompt("Введите координату X второй точки:");
double y2=Prompt("Введите координату Y второй точки:");
double z2=Prompt("Введите координату Z второй точки:");

Console.WriteLine(FindLength(x1,y1,z1,x2,y2,z2));