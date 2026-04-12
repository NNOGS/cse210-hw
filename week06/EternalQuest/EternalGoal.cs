using System;// Importing the system Library

// Decaring the class and it's inheritance from the base Goal
public class EternalGoal : Goal
{
    // Constructor declaration with it's base but running whenever a new EternalGoal is created.
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)// calling the base class constructor here.
    {
    }

    // Method Override of an int RecordEvent
    public override int RecordEvent()
    {
        return _points;
    }

    // Method Override of a string GetStringRepresentation
    public override string GetStringRepresentation()
    {
        return $"Eternal: {_name}, {_description},{_points}"; //Stores in text format to be reused.
    }
}

