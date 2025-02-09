class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    private List<string> _userResponses = new List<string>();

    public ListingActivity() : base("Listing Activity",
        "This activity helps you reflect on the good things in your life.")
    {
    }

    protected override void PerformActivity()
    {
        Random random = new Random();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
        Console.WriteLine("You have a few seconds to think before starting...");
        ShowCountdown(5);

        int elapsedTime = 0;
        while (elapsedTime < _duration)
        {
            Console.Write("Enter an item: ");
            _userResponses.Add(Console.ReadLine());
            elapsedTime += 5;
        }

        Console.WriteLine($"You listed {_userResponses.Count} items.");
    }
}
