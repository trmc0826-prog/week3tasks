    string path = "blackbox.txt";

    // TODO: Hvis filen ikke finnes, skriv eksempeldata.
    // TODO: Les så alle linjene og skriv dem ut.

    if (!File.Exists(path))
    {
    string[] messages = {"eksempeldata", "mayday", "crash"};
    File.WriteAllLines(path, messages);
    }

    string[] lines = File.ReadAllLines(path);

    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }