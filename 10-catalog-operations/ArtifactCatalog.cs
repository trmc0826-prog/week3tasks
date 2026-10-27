public class ArtifactCatalog
{
    private List<Artifact> artifacts = new List<Artifact>();

    public void Add(Artifact artifact)
    {
        // TODO
    artifacts.Add(artifact);
    }
    public void PrintAll()
    {
        // TODO
    foreach (Artifact artifact in artifacts)
    {
        Console.WriteLine($"{artifact.Name} {artifact.Origin}");
    }
    }

    public Artifact? FindByName(string name)
    {
        // TODO: Finn manuelt med løkke.
        foreach (Artifact artifact in artifacts)
        {
            if(artifact.Name == name)
            {
                return artifact;
            }
            
        }
        return null;
    }
}
