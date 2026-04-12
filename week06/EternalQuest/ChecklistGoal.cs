using System; // Importing the system Lirary

// Declaring the class and depicting inheritance from the parent Goal
public class ChecklistGoal : Goal
{
    // Declaring private member variables from the ones inherited
    private int _amountCompleted;//Stores info on how many times the task has been done
    private int _target;//Stores how many times it must be completed
    private int _bonus;//Stores extra points to be awarded once the goal is finished.

    //Constructor - Runs when a ChecklistGoal object is initiated
    public ChecklistGoal(string name, string desc, int points, int target, int bonus)
        : base(name, desc, points)// it accepts 5 pieces of info including the ones inherited
    {
        _target = target; // Required Completions
        _bonus = bonus; // Bonus when finished
        _amountCompleted = 0; // Number of times completed
    }

        // Method Override on RecordEvent
    public override int RecordEvent()
    {
        _amountCompleted++; // Increment completion count

        if (_amountCompleted == _target) // if condition on equality
        {
            return _points + _bonus; // Return point + bonus together
        }
        return _points; // as points
    }

    // Method override on IsComplete
    public override bool IsComplete() // Method confirms if Goal is complete.
    {
        return _amountCompleted >= _target;// on this condition in line 35
    }

    // Method override on the string GetDetailsstring
    public override string GetDetailsString()
    {
        return $"{_name} -- Completed {_amountCompleted}/{_target}";// Returns developer's format on goal description.
    }

    //Method override on the string GetStringRepresentation
    public override string GetStringRepresentation()// converting the Goal into a string format to be saved.
    {
        return $"Checklist: {_name}, {_description}, {_points}, {_target}, {_bonus}";// Here is the format which helps to store and reload later.
    }
}