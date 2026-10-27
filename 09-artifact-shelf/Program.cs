List<Artifact> artifacts = new List<Artifact>();

// TODO: Opprett minst fire Artifact-objekter og legg dem i listen.
// TODO: Skriv Count og alle objektene.
// TODO: Legg til ett ekstra objekt og skriv Count igjen.

Artifact artifactOne = new Artifact("Shrine", "Landas", 3);
artifacts.Add(artifactOne);

Artifact artifactTwo = new Artifact("Shire", "Kjyr", 2);
artifacts.Add(artifactTwo);

Artifact artifactThree = new Artifact("Smøyra", "Morvik", 1);
artifacts.Add(artifactThree);

Artifact artifactFour = new Artifact("Kolsvik", "Stjorn", 4);
artifacts.Add(artifactFour);

Console.WriteLine($"Currently {artifacts.Count} artifacts");

    foreach (Artifact artifact in artifacts)
    {
    Console.WriteLine($"{artifact.Name} {artifact.Origin} {artifact.Risk}");
    }

Artifact artifactFive = new Artifact("Kols", "Måke", 1);
artifacts.Add(artifactFive);

Console.WriteLine($"Currently {artifacts.Count} artifacts");