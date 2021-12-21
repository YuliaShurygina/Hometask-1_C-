// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int number = new Random().Next(10, 100);
Console.WriteLine("число " + number);
int tens = number % 100 / 10; 
int unit = number % 10; 
if (tens > unit)
{
    Console.WriteLine("Наибольшая цифра " + tens);
}
else
{
    Console.WriteLine("Наибольшая цифра " + unit);
}
