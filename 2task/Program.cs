Console.WriteLine("Введите первое целое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число");
int num2 = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (num1 > num2)
{
    max = num1;
}

else 
{
    max = num2;
}

Console.WriteLine($"Максимальное число равно {max} ");
