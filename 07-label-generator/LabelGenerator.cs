public class LabelGenerator
{
    public string CreateLabel(string rawText)
    {
        // TODO: Bruk den private helperen og returner f.eks. "LABEL: LUNAR SAMPLE".
        return $"LABEL: {Normalize(rawText)}";
    }

    private string Normalize(string rawText)
    {
        // TODO: Trim og gjør teksten uppercase.
        return rawText.Trim().ToUpper();
    }
}
