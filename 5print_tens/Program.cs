// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число : ");
int number = int.Parse(Console.ReadLine()??"0");
int tens = number % 100 / 10; 
Console.WriteLine("Вторая цифра "+tens);
