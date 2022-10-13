// Домашняя работа 3.
// Задача 1.
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void FiveDigitPalindrome(string num)
{   
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine($"{num} - palindrome");
    }
    else
    {
        Console.WriteLine($"{num} - not a palindrome");
    }
}

Console.Write("Input a five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
string num = Convert.ToString(number);
FiveDigitPalindrome(num);

// Задача 2.
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double FindDistans(double a, double a1,  double y, double y1, double z, double z1)
{
    double num = 0;
    num = ((Math.Pow((a - a1), 2)) + (Math.Pow((y - y1), 2)) + (Math.Pow((z - z1), 2)));
    num = Math.Sqrt(num);
    return num;
}

Console.Write("Inpute coordinate a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Inpute coordinate a1: ");
double a1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Inpute coordinate y: ");
double y = Convert.ToDouble(Console.ReadLine());
Console.Write("Inpute coordinate y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Inpute coordinate z: ");
double z = Convert.ToDouble(Console.ReadLine());
Console.Write("Inpute coordinate z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());

double findDistans = FindDistans(a, a1, y, y1, z, z1);
Console.WriteLine(findDistans);

// A (7,-5, 0); B (1, -1, 9) -> 11.53
//    a  y  z      a1 y1 z1

// Задача 3. 
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void ShowNumbers(int num)
{
    int count = 1;
    while(count <= num)
    {
        double n = Math.Pow(count, 3);
        Console.Write(n + " ");
        count++;
    }
}

Console.Write("Inpute digit: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowNumbers(number);