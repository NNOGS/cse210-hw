using System;


public class Word
{
    private string _text;
    private bool _isHidden;


    // Word with it's parameter as text in string form.
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Word behavior or attribute via method
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }
    // Check if the word is Hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // With the if statement return new string if word is hidden
    // or otherwise return text
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}