using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.AddGoal(new SimpleGoal("Visit a Friend", 100));
        manager.AddGoal(new ChecklistGoal("Read Books", 50, 5));
        manager.AddGoal(new EternalGoal("Exercise Daily", 10));

        manager.DisplayGoals();
    }
}