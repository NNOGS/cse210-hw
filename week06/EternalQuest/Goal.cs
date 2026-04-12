using System; // Importing the system Library
using System.Runtime.InteropServices; // with the runtime and intropservices

// Declaring the base class from which others inherited their attributes
public class Goal
{
    // Common properties declared below to be inherited by 
    // the children class but protected as member variables
    //  to grant access to the children class and inside this one but not outside directly.
    protected string _name;//Info stored - Goal name
    protected string _description;// Info stored - Goal description
    protected int _points;//info stored - Point earned when Goal is recorded.

    //Constructor running when a Goal or derived object is created
    public Goal(string name, string description, int points)
    {
        //Assigning values to variables
        _name = name;
        _description = description;
        _points = points;
    }

    // Method of a virtual int RecordEvent for recoding progress on goal by defaul.
    public virtual int RecordEvent()
    {
        return _points; // Returns points or Goal number by default
    }

    // Method of a virtual bool IsComplete for checking if a goal is finished or completed.
    public virtual bool IsComplete()
    {
        return false; // returning false by default showing it is not complete but will be overwritten by the derived classes.
    }

    //Method of a virtual string GetDetailsString 
    public virtual string GetDetailsString()
    {
        return $"{_name} ({_description})";//Returns a formatted description of the Goal.
    }

    // Method of a virtual string GetStringRepresentaton
    public virtual string GetStringRepresentation()
    {
        return $"Goal: {_name}, {_description}, {_points}";//Converts the goal into a string format used for saving the goal.
    }
}