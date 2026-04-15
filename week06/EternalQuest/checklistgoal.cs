public class ChecklistGoal : Goal
{
    private int _target;
    private int _current;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _current = 0;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _current++;

        if (_current == _target)
        {
            Console.WriteLine("🎉 Goal Completed! Bonus awarded!");
            return _points + _bonus;
        }

        return _points;
    }

    public override bool IsComplete()
    {
        return _current >= _target;
    }

    public override string GetStatus()
    {
        return $"[{_current}/{_target}] {_name}";
    }

    public override string SaveData()
    {
        return $"Checklist|{_name}|{_description}|{_points}|{_current}|{_target}|{_bonus}";
    }
}
