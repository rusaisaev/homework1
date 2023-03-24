Console.Clear();
Console.WriteLine("Введите первое число ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число ");
int c = int.Parse(Console.ReadLine()!);
// приняли числа 
int max = a;
if(b > max) max = b;
if(c > max) max = c;
else Console.WriteLine("==");

Console.WriteLine(max);
 

/* - if(a > b) Console.WriteLine(a);
else if(b > a) Console.WriteLine(b);
else if(a > c) Console.WriteLine(a);
else if(c > a) Console.WriteLine(c);
else if(b > c) Console.WriteLine(b);
else if(c > b) Console.WriteLine(c);
else Console.WriteLine("==");
*/