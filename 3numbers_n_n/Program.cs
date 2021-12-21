Console.WriteLine("Введите число N: ");
int number = int.Parse(Console.ReadLine()??"0");
int i = 0;

while (i <= number*2)
{
    int k = i - number;
    Console.Write(k +" " );   
    i = i + 1;
}

