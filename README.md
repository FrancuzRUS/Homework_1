Ссылка на GitHub: 
https://github.com/FrancuzRUS/Homework_1.git 



1. По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("Введите число А ");
int A = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите число B ");
int B = int.Parse(Console.ReadLine());
if (A == B*B) Console.Write("УРА!!! Число А является квадратом числа B");
else Console.Write("О НЕТ!!! Числов А НЕ является квадратом числа B");


2. По заданному номеру дня недели вывести его название

Console.WriteLine("Введите цифру от 1 до 7 ");
int A = int.Parse(Console.ReadLine());
if (A == 1) Console.WriteLine("Понедельник ");
if (A == 2) Console.WriteLine("Вторник ");
if (A == 3) Console.WriteLine("Среда ");
if (A == 4) Console.WriteLine("Четверг ");
if (A == 5) Console.WriteLine("Пятница ");
if (A == 6) Console.WriteLine("Суббота ");
if (A == 7) Console.WriteLine("Воскресенье ");



3. Выяснить является ли число чётным

Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine());
if (A%2==0) Console.WriteLine("Число четное");
else Console.WriteLine("Число нечетное");


4. Показать четные числа от 1 до N

Console.WriteLine("Будем искать все четные числа от 1 до N. Введите число N: ");
int N = int.Parse(Console.ReadLine());

for (int i=1; i <= N; i++)
    if (i%2==0) Console.WriteLine(i);

5. Показать вторую цифру трёхзначного числа
// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число");
int N = int.Parse(Console.ReadLine());
N=N/10;
N=N%10;
Console.WriteLine(N);



6. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

// // Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.WriteLine("Введите число от 10 до 99");
int C = int.Parse(Console.ReadLine());
int A=C%10;
int B=C/10;
if (C>99) Console.WriteLine("Введите число из диапазоно от 10 до 99");
else if (C<10) Console.WriteLine("Введите число из диапазоно от 10 до 99");
else if (A > B) Console.WriteLine($"Наибольшая цифра введенного числа {A}");
else Console.WriteLine($"Наибольшая цифра введенного числа {B}"); 

7. Удалить вторую цифру трёхзначного числа

// Удалить вторую цифру трёхзначного числа
int N = new Random().Next(100,1000); 
Console.WriteLine($"Случайное трехзначеное число {N}");
int A = N%10;
int B= N/100;
N=B*10+A;
Console.WriteLine($"После удаления второй цифры в числе {N}");

8. Выяснить, кратно ли число заданному, если нет, вывести остаток.
//Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите число А(Кратно чему?)");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B(Проверяемое на кратность)");
int b =int.Parse(Console.ReadLine());
if (b%a==0)Console.WriteLine($"Число B= {b} кратно числу А= {a}");
else Console.WriteLine($"Число B= {b} не кратно числу А= {a}, остаток от деления равен {a%b}");


9. Найти третью цифру числа или сообщить, что её нет

// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
if (a<100) Console.WriteLine("Нет третьей цифры числа");
else if (a<1000) Console.WriteLine($"Третья цифра числа {a%10}");
else { while (a>1000)
        a=a/10;
    Console.WriteLine($"Третья цифра числа {a%10}");
    } 

