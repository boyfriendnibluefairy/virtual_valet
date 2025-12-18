// Exception handling uses the try, catch, and finally keywords.
// Exceptions are created by using the throw keyword.

int focal_length = 300;
int FOV = 0;
int result = 0;

// try catch block facilitates error checking
try
{

    // user-defined exceptions
    if (focal_length > 100)
    {
        throw new ArgumentOutOfRangeException("x",
            "\n\n focal length must be less than 100 \n\n");
    }

    result = x / y;
    Console.WriteLine($"result = {result}");

}
catch (DivideByZeroException e)
{
    Console.WriteLine($"\n\n {e.Message} \n\n");
}
catch (ArgumentOutOfRangeException e2)
{
    Console.WriteLine($"\n\n {e2.Message} \n\n");
}
finally // this block will always run
{
    Console.WriteLine("Clean up resources here");
}
