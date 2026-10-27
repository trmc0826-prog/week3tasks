string path = "creatures.txt";

List<Creature> creatures = new List<Creature>
{
    new Creature("Mora", "Lumen Fox", 72),
    new Creature("Kip", "Dust Eel", 18),
    new Creature("Senn", "Cloud Moth", 41)
};

List<string> fileLines = new List<string>();

foreach (Creature creature in creatures)
{
     fileLines.Add(creature.ToFileLine());
}
File.WriteAllLines(path, fileLines);

string[] lines = File.ReadAllLines(path);

List<Creature> loadedCreatures = new List<Creature>();
foreach (string line in lines)
{
    string[] parts = line.Split('|');
    if (parts.Length  == 3)
    {
        if (int.TryParse(parts[2], out int energy))
        {
            Creature loaded = new Creature(parts[0], parts[1], energy);
            loadedCreatures.Add(loaded);
        }
    }
}
foreach (Creature loaded in loadedCreatures)
{
    Console.WriteLine($"{loaded.Name} {loaded.Species} {loaded.Energy}");
}

// TODO: Konverter objektene til linjer og skriv dem til fil.
// TODO: Les filen.
// TODO: Rekonstruer gyldige Creature-objekter i en ny liste.
// TODO: Skriv resultatet.