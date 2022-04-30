// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
if (a<100) Console.WriteLine("Нет третьей цифры числа");
else if (a<1000) Console.WriteLine($"Третья цифра числа {a%10}");
else { while (a>1000)
        a=a/10;
    Console.WriteLine($"Третья цифра числа {a%10}");
    } 