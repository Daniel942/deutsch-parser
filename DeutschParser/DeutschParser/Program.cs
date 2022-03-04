ConsoleColor defaultColor = ConsoleColor.Yellow;
ConsoleColor inputColor = ConsoleColor.White;
ConsoleColor errorColor = ConsoleColor.Red;
ConsoleColor successColor = ConsoleColor.Green;

bool complete = false;
while (!complete)
{
    Console.ForegroundColor = defaultColor;
    Console.WriteLine("Input file name with relative or absolute path:");

    Console.ForegroundColor = inputColor;
    string? filePath = Console.ReadLine();
    Console.ForegroundColor = defaultColor;

    if (string.IsNullOrEmpty(filePath))
    {
        continue;
    }

    string fileName = Path.GetFileName(filePath);

    if (!File.Exists(filePath) || string.IsNullOrEmpty(fileName))
    {
        Console.ForegroundColor = errorColor;
        Console.WriteLine($"File '{fileName}' does not exist.");
        Console.ForegroundColor = defaultColor;
        continue;
    }

    Console.WriteLine($"Reading file '{fileName}' ...");

    string fileText = File.ReadAllText(filePath);
    if (string.IsNullOrEmpty(fileText))
    {
        Console.WriteLine($"File '{fileName}' contains no text.");
        continue;
    }

    Console.WriteLine("Parsing file contents ...");

    Console.ForegroundColor = successColor;
    Console.WriteLine("Finished.");

    complete = true;
    Console.ForegroundColor = inputColor;
}
