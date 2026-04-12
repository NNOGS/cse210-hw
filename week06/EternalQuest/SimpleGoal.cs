using System; // Importing the system Library

// Declaring the class below with it's base
public class SimpleGoal : Goal
{
    // Variable declaration is stored in _isComplete in bool format in the form of true(completed) or false(not completed)
    private bool _isComplete;

    // Constructor - whichi runs when a simple goal is created
    public SimpleGoal(string name, string desc, int points)
        : base(name, desc, points)
    {
        _isComplete = false;// initially set as default - false(not completed)
    }

    // Method override on int RecordEvent
    public override int RecordEvent()
    {
        _isComplete = true;// on conditions of being completed or progress to the recorded goal,
        return _points; // Return with goal points to user.
    }

    // Method override checks if goal is finished
    public override bool IsComplete()
    {
        return _isComplete;// returns completed
    }

    //Method override on string GetStringRepresentation
    public override string GetStringRepresentation()
    {
        return $"Simple: {_name}, {_description}, {_points}";// converts goal into a text format for saving into a file as it returns it in the format on line 32
    }
}