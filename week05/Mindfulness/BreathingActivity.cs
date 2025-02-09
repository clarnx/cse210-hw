class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity",
        "This activity helps you relax by guiding your breathing.")
    {
    }

    protected override void PerformActivity()
    {
        int elapsedTime = 0;
        while (elapsedTime < _duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3);
            elapsedTime += 3;

            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
            elapsedTime += 3;
        }
    }
}
