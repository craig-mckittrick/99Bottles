
int bottles = 99;
for (int i = bottles; i >= 0; i--)
{
    switch (i)
    {
        case > 2:
            Console.WriteLine();
            Console.WriteLine($"{bottles} bottles of beer on the wall, {bottles} bottles of beer.");
            Console.WriteLine($"Take one down and pass it around, {--bottles} bottles of beer on the wall.");
            break;
        case 2:
            Console.WriteLine();
            Console.WriteLine($"{bottles} bottle of beer on the wall, {bottles} bottle of beer.");
            Console.WriteLine($"Take one down and pass it around, {--bottles} bottle of beer on the wall.");
            break;
        case 1:
            Console.WriteLine();
            Console.WriteLine($"{bottles} bottle of beer on the wall, {bottles} bottle of beer.");
            Console.WriteLine($"Take one down and pass it around, {--bottles} bottles of beer on the wall.");
            break;
        case 0:
            Console.WriteLine();
            Console.WriteLine("No more bottles of beer...go to the store and buy some more.");
            Console.WriteLine("How many bottles of beer do you want to buy? [Enter 0 to quit]");
            while (true)
            {
                string? input = Console.ReadLine();

                if (!int.TryParse(input, out _) || string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Please enter a number.");
                }
                else
                {
                    int moreBeer = Convert.ToInt32(input);
                    switch (moreBeer)
                    {
                        case > 0:
                            Console.WriteLine($"You purchased {moreBeer} bottles of beer!");
                            return;
                        case 0:
                            return;
                    }
                }
            }
    }
}


