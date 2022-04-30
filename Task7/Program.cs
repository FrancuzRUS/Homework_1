// Удалить вторую цифру трёхзначного числа
int N = new Random().Next(100,1000); 
Console.WriteLine($"Случайное трехзначеное число {N}");
int A = N%10;
int B= N/100;
N=B*10+A;
Console.WriteLine($"После удаления второй цифры в числе {N}");