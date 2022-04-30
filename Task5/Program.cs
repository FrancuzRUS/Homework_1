// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число");
int N = int.Parse(Console.ReadLine());
N=N/10;
N=N%10;
Console.WriteLine($"Вторая цифра данного числа {N}");
