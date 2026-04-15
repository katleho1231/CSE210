public class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public virtual int RecordEvent()
    {
        return _points;
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetStatus()
    {
        return "[ ] " + _name;
    }

    public virtual string SaveData()
    {
        return $"{_name}|{_description}|{_points}";
    }
}
