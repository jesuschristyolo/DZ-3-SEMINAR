using static System.Console;

Write("Введите число для вывода таблицы кубов от 1 до вашего числа: ");
int.TryParse(ReadLine(), out int n);
int i = 1;

while (i < n + 1 )
{
    WriteLine ($"{i} = {Math.Pow(i, 3)}");
    i++;
}