// sample values
int focal_length = 33;
int[] entrance_pupil_diameters = new int[6] { 7, 8, 12, 13, 20, 24 };
string msg = "Calculating FOV...";

// basic for loops
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("i = {0}", i);
}
Console.WriteLine("\n");

// foreach loop
foreach (int num in entrance_pupil_diameters)
{
    Console.WriteLine("num = {0}", num);
}
Console.WriteLine("\n");

// count characters
int counter = 0;
foreach (char c in msg)
{
    counter++;
}
Console.WriteLine("number of characters = {0}",
    counter);

// sample value
string word = "";

// while loops
while (word != "exit")
{
    word = Console.ReadLine();
    Console.WriteLine("You entered: {0}", word);
    Console.WriteLine("\n");
}

// do while loop
do
{
    word = Console.ReadLine();
    Console.WriteLine("You entered: {0}", word);
    Console.WriteLine("\n");
} while (word != "stop");

// sample array
int[] z_exit_pupil = { 16, 6, 17, 27, 40, 61, 100, 19, 99 };

// use of break and continue keywords
foreach (int v in z_exit_pupil)
{

    // continue skips current iteration and jumps to the next iteration
    // if it is still possible
    // exclude numbers from 20 to 90
    if ((v > 20) && (v < 90))
    {
        continue;
    }


    Console.WriteLine($"Current value is {v}");

    // get first instance of value greater than 60
    //if (v >= 60) break;
}


