Console.Write("Введите 3 значное число: ");
int ShowMidNum(int number)
{
    int remain = number % 100;
    return remain / 10;
}

int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 || num > 999)
{
Console.WriteLine("Вы ввели не 3 значное число");
}
else
{
Console.WriteLine(ShowMidNum(num));
}