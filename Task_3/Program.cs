using static System.Console;

WriteLine("Введите число палиндром");
int numbers = int.Parse(ReadLine()!);
int a = numbers / 10000;
int a1 = numbers % 10000;
int b = a1 / 1000;
int b1 = a1 % 1000;
int c = b1 % 100;
int d = b1 % 10;
int d1 = c / 10;
int e = d / 1;
// WriteLine ($"{a} {b} {d1} {e} ");
if (a == e && b == d1)
{
    WriteLine ("Число является палиндромом");
}
else
{
     WriteLine ("Число не является палиндромом");
}