class Program
{
    static void Main()
    {
        PrintTransmission("System ready");
        PrintTransmission("Dock", "Gate unlocked");
        PrintTransmission("Dock", "Gate unlocked", 2);

        // TODO: Kall også din tredje overload.
    }

    static void PrintTransmission(string message)
    {
        Console.WriteLine($"[UNKNOWN] {message}");
    }

    static void PrintTransmission(string sender, string message)
    {
        Console.WriteLine($"[{sender}] {message}");
    }

    // TODO: Lag tredje overload.
    static void PrintTransmission(string sender, string message, int repeats)
    {
        for (int i = 0; i < repeats; i++)
        {
            Console.WriteLine($"[{sender}] {message}");
        }
    }
}