class Program
{
    static void Main()
    {
        GoalManager goalManager = new GoalManager();
        goalManager.LoadGoals();

        while (true)
        {
            Console.WriteLine("\nEternal Quest - Goal Tracker");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    goalManager.DisplayPlayerInfo();
                    break;
                case "2":
                    goalManager.ListGoalNames();
                    break;
                case "3":
                    Console.Write("Enter goal number to record an event: ");
                    if (int.TryParse(Console.ReadLine(), out int goalIndex))
                    {
                        goalManager.RecordEvent(goalIndex - 1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                    break;
                case "4":
                    goalManager.SaveGoals();
                    Console.WriteLine("Goals saved successfully.");
                    break;
                case "5":
                    goalManager.SaveGoals();
                    Console.WriteLine("Exiting... Goals saved.");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
