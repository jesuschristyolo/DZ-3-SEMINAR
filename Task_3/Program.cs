using static System.Console;

WriteLine("Введите число палиндром");
int numbers = int.Parse(ReadLine());
int a = numbers / 10000;
int a1 = numbers % 10000;
int b = a1 / 1000;
int b1 = a1 % 1000;
int c = b1 % 100;
int d = b1 % 10;
int d1 = c / 10;
int e = d / 1;
// WriteLine ($"{a} {b} {d1} {e} ");
if (a = b )
{
    
}
else
{
    WriteLine ("число не является палиндромом");
}
if (d1 = e )
{
    WriteLine ("число является палиндромом");
}
else
{
    WriteLine ("число не является палиндромом");
}