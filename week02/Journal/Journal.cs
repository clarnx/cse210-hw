// Journal.cs

public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public void AddEntry()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(prompt);
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        entries.Add(new Entry(prompt, response));
        Console.WriteLine("Entry added!\n");
    }

    public void DisplayJournal()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries found.\n");
            return;
        }

        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile()
    {
        Console.Write("Enter the filename to save the journal: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine(entry);
            }
        }

        Console.WriteLine("Journal saved to file.\n");
    }

    public void LoadFromFile()
    {
        Console.Write("Enter the filename to load the journal: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.\n");
            return;
        }

        entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        for (int i = 0; i < lines.Length; i += 4)
        {
            string dateLine = lines[i];
            string promptLine = lines[i + 1];
            string responseLine = lines[i + 2];

            string prompt = promptLine.Replace("Prompt: ", "");
            string response = responseLine.Replace("Response: ", "");
            entries.Add(new Entry(prompt, response));
        }

        Console.WriteLine("Journal loaded from file.\n");
    }
}
