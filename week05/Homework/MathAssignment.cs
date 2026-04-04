using System;

// define the class MathAssignment as a sudo to the Super class Assignment hence the colon
public class MathAssignment : Assignment
{
    private string _section;
    private string _problems;

    // Constructor have 4 parameters but with 2 as base from the assignment class
    public MathAssignment(string studentName, string topic, string section, string problems)
     : base(studentName, topic)
     {
        _section = section;
        _problems = problems;
     }

    // define the GetHomeworklist method below to return the section of the textbook and problem.
     public string GetHomeworkList()
     {
        return $"Section {_section} Problems {_problems}";
     }
}
