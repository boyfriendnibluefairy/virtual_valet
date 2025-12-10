// sample values
int a = 33, b = 5;
string c = "hello", d = "world";

Console.WriteLine("====== Math Operations ======");
Console.WriteLine((a + b) / 2);
Console.WriteLine(c + " " + d);

Console.WriteLine("====== Increment and Decrement Operators ======");
a++; b--;
Console.WriteLine(a);
Console.WriteLine(b);

Console.WriteLine("====== Null Coalescing Operator ======");
string x1 = null;
string x2 = "violet";
Console.WriteLine(x1 ?? "no value");
Console.WriteLine(x2 ?? "Evergarden");
Console.ReadKey();
