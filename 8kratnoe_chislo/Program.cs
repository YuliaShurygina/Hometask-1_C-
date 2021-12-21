// Выяснить, кратно ли число заданному, если нет, вывести остаток.
int number1 = new Random().Next(1, 1000);
Console.WriteLine("Заданное число " + number1);
Console.Write("Введите число  ");
int number2 = int.Parse(Console.ReadLine()??"0");
int remainder = number1 % number2;
if (remainder == 0)
{
    Console.WriteLine("Число кратно заданному");
}
else
{
    Console.WriteLine("Остаток от деления равен " + remainder);
}




