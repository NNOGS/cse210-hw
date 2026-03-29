using System;
using System.Collections.Generic;

public class Video
{
    //Member variales
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    // Constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    // Add a comment
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    // Return number of comments
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
}