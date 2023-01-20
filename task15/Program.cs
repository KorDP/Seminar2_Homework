Console.Write("Введите число от обозначающее день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day >= 1 && day <= 7)
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine("Выходной день");
    } 
    else
    {
        Console.WriteLine("Будний день");
    }
}
else
{
    Console.WriteLine("Такого дня недели нет");
}