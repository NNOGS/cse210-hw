using System;

public class Assignment
{
    private string _studentName;
    private string _topic;

    // Using Consructors below, we define the variables
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Using Getters as methods to grant access to our private variables
    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _studentName +"-"+ _topic;
    }

}