// Declare variables with basic data types
// decimal use m because d is already taken by double
int a = 30;
float b = 1.0f;
double c = 2.0d;
decimal d = 3.0m;
bool e = true;
char f = 'f';

// String is an array of characters
string message = "hello world";

// var is usually used for foreach()
var x = 1;

// declare an empty array
string[] msg = { "hello", "world", "awesome" };

Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", a, b, c, d, e, f, x);
foreach (var m in msg)
{
    Console.WriteLine(m);
}
Console.ReadKey();


// "null" means no value
object xObject = null;
Console.WriteLine(xObject);
Console.WriteLine("null has been printed");
Console.ReadKey();
