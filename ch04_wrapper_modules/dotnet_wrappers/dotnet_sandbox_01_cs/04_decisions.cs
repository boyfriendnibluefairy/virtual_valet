
// sample value
int focal_length = 100;

// if else statement
if (focal_length == 100)
{
    Console.WriteLine("focal length is 100");
}
else
{
    Console.WriteLine("focal length is is not 100.\n");
}

// if else can be replaced by ternary operator
Console.WriteLine(focal_length < 100 ? "the focal length is less than 100" : "the focal length is 100 and above");


// sample value
int FOV = 53;

// switch statement
switch (FOV)
{
    case 00:
    case 59:
        Console.WriteLine("FOV is low");
        break;
    case 60:
        Console.WriteLine("FOV is 60");
        break;
    case 61:
    case 100:
        Console.WriteLine("FOV is high");
        break;
    default:
        Console.WriteLine("invalid FOV");
        break;
}
