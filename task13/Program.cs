int ThirdDigit(int number)
 {
     int result = -1;
     if (number >= 100)
     {
        while (number > 999)
        {
            number = number / 10;
            }
            result = number % 10;
            }
            return result;
            }

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (ThirdDigit(number) == -1)
Console.WriteLine("третьей цифры нет");
else
{
Console.WriteLine ($"{ThirdDigit (number)}");
}
