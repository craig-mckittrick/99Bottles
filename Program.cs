
int bottles = 99;
for (int i = bottles; i >= 0; i--)
{
    switch (i)
    {
        case > 1:
            Console.WriteLine();
            Console.WriteLine($"{bottles} bottles of beer on the wall, {bottles} bottles of beer.");
            Console.WriteLine($"Take one down and pass it around, {--bottles} bottles of beer on the wall.");
            break;
        case 1:
            Console.WriteLine();
            Console.WriteLine($"{bottles} bottle of beer on the wall, {bottles} bottle of beer.");
            Console.WriteLine($"Take one down and pass it around, {--bottles} bottles of beer on the wall.");
            break;
        case 0:
            Console.WriteLine();
            Console.WriteLine("No more bottles of beer...go to the store and buy some more.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            break;
    }
}


