public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CurrentCount { get; set; }

    public ChecklistGoal(string name, int points, int targetCount) : base(name, points)
    {
        TargetCount = targetCount;
        CurrentCount = 0;
    }

    public override void RecordEvent()
    {
        if (CurrentCount < TargetCount)
        {
            CurrentCount++;
        }
    }

    public override string GetDetailsString() => $"{base.GetDetailsString()}, Progress: {CurrentCount}/{TargetCount}";
}