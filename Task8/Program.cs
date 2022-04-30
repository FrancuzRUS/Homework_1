//Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите число А(Кратно чему?)");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B(Проверяемое на кратность)");
int b =int.Parse(Console.ReadLine());
if (b%a==0)Console.WriteLine($"Число B= {b} кратно числу А= {a}");
else Console.WriteLine($"Число B= {b} не кратно числу А= {a}, остаток от деления равен {a%b}");


