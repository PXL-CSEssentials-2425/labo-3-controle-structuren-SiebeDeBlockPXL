Console.WriteLine("Welcome to Knight vs Goblin!");
Console.WriteLine("---------------------------");
Console.Write("Enter knight health: ");
string input = Console.ReadLine();

Random randomNumberGenerator = new Random();

// Initialiseer levenspunten van knight
int knightHealth;
if (int.TryParse(input, out knightHealth))
{
    if (knightHealth <= 0 || knightHealth > 100)
    {
        // Waarde van getal te klein of te groot
        Console.WriteLine("Invalid number, default value 100 is used.");
        knightHealth = 100;
    }
}
else
{
    // Ongeldig getal ingegeven
    Console.WriteLine("Invalid number, default value 100 is used.");
    knightHealth = 100;
}

// Initialiseer levenspunten van goblin
int goblinHealth = randomNumberGenerator.Next(1, 101);

Console.WriteLine($"Knight health: {knightHealth}");
Console.WriteLine($"Goblin health: {goblinHealth}");

//for(int attempts = 1; attempts <= 4; attempts++)
do
{
    //Console.WriteLine($"Ronde {attempts}");
    int attackKnight = 10;
    int attackGoblin = randomNumberGenerator.Next(5, 16);

    Console.WriteLine("Choose your next move carefully: ");
    Console.WriteLine("1. Attack");
    Console.WriteLine("2. Heal");
    Console.Write("Enter your choice: ");
    string selectedAction = Console.ReadLine();

    switch (selectedAction)
    {
        case "1":
            goblinHealth -= attackKnight;
            // Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"You attacked the goblin for {attackKnight} damage!");
            // Console.ResetColor();
            break;
        case "2":
            knightHealth += 10;
            // Console.ForegroundColor = ConsoleColor.Blue;   
            Console.WriteLine("You healed yourself for 10 health points!");
            // Console.ResetColor();
            break;
        default:
            // Console.ForegroundColor = ConsoleColor.Magenta;   
            Console.WriteLine("Invalid move! Please choose a vaild move.");
            // Console.ResetColor();
            break;
    }

    if (goblinHealth > 0)
    {
        knightHealth -= attackGoblin;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"You were attacked by the goblin for {attackGoblin} damage!");
        Console.ResetColor();
    }
    if (knightHealth <= 0)
    {
        Console.WriteLine("You have died!");
    }
    else
    {
        Console.WriteLine($"Knight health: {knightHealth}");
    }

    if (goblinHealth <= 0)
    {
        Console.WriteLine("The goblin has died!");
    }
    else
    {
        Console.WriteLine($"Goblin health: {goblinHealth}");
    }
} while (knightHealth > 0 && goblinHealth > 0);