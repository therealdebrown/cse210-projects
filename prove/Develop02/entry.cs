using System;

public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;

    public Entry(string promptText, string entryText)
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();
    }

    public string ToFileFormat()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }

    public static Entry FromFileFormat(string fileLine)
    {
        var parts = fileLine.Split('|');
        if (parts.Length == 3)
        {
            return new Entry(parts[1], parts[2]) { _date = parts[0] };
        }
        throw new Exception("Invalid file format.");
    }
}
