// По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("Введите число А ");
int A = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите число B ");
int B = int.Parse(Console.ReadLine());
if (A == B*B) Console.Write("УРА!!! Число А является квадратом числа B");
else Console.Write("О НЕТ!!! Числов А НЕ является квадратом числа B");