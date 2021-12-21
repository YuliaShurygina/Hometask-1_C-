Console.WriteLine("Введите трехзначное число : ");
int number = int.Parse(Console.ReadLine()??"0");
int unit = number % 10; 
Console.WriteLine("Последняя цифра "+unit);
