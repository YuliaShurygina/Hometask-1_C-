// Удалить вторую цифру трёхзначного числа
int number = new Random().Next(100, 1000);
Console.WriteLine("Трехзначное число " + number);
int hundred = number / 100;
int unit = number % 10; 

Console.WriteLine("Удалили десятки " + hundred + unit);
