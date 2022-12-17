Console.WriteLine("Введите первое число");
string numberFirst = Console.ReadLine() ??"";
int number1 = int.Parse(numberFirst);
int result1 = number1;

Console.WriteLine("Введите второе число число");
string numberSecond = Console.ReadLine();
int number2 = int.Parse(numberSecond);
int result2 = number2;

    if (number1 > number2)
    {
        Console.WriteLine($"число {number1} больше а число {number2} меньше");
    }

    Console.WriteLine($"число {number1} меньше а число {number2} больше"); 