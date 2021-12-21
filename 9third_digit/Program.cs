// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите число : ");
int number = int.Parse(Console.ReadLine()??"0");
int unit = number % 10; 
if (number < 100) 
{
    Console.WriteLine("Третьей цифры числа нет" );
}

if (number <= 999 & number > 99)
{
        Console.WriteLine("Третья цифра числа = " + unit);
}
while (number > 999)
{
     number = number / 10;
    
}
unit = number % 10;
Console.WriteLine("Третья цифра числа = " + unit);