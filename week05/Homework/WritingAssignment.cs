using System;

// Below is the WritingAssignment class as a sudo to the super class Assignment
public class WritingAssignment : Assignment
{
    private string _title;

    // The constructor here below have 3 parameters but only to define one while the rest 2 will be for the base
    public WritingAssignment(string studentName, string topic, string title)
    : base(studentName, topic)
    {
        _title = title;
    }

    // 
    public string GetWritingInformation()
    {
        //call getter below via studentName cos of privacy
        string studentName = GetStudentName();

        return $"{_title} by {GetStudentName()}";
    }
}