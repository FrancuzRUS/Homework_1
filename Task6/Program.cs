// // Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.WriteLine("Введите число от 10 до 99");
int C = int.Parse(Console.ReadLine());
int A=C%10;
int B=C/10;
if (C>99) Console.WriteLine("Введите число из диапазоно от 10 до 99");
else if (C<10) Console.WriteLine("Введите число из диапазоно от 10 до 99");
else if (A > B) Console.WriteLine($"Наибольшая цифра введенного числа {A}");
else Console.WriteLine($"Наибольшая цифра введенного числа {B}"); 
