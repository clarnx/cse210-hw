// I added creativity by implementing the features below
// Added random scripture selection.
// Included a complete hiding check to end the program when all words are hidden.
// Created a console loop for progressive word hiding and user engagement.

class Program
{
    static void Main(string[] args)
    {
        var scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all this through him who gives me strength.")
        };

        // Select a random scripture
        var random = new Random();
        var selectedScripture = scriptures[random.Next(scriptures.Count)];

        // Main loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            var input = Console.ReadLine();

            if (input?.ToLower() == "quit")
            {
                break;
            }

            selectedScripture.HideRandomWords(3);

            if (selectedScripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine("All words are hidden. Goodbye!");
                break;
            }
        }
    }
}