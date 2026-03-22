using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;


    // Initiating A Conductor  with 2 parameters to reference 
    // the scripture text.
    public Scripture(string text, Reference reference)
    {
        _reference = reference;
        _words = new List<Word>();

        //Split the text into individual words
        string[] wordArray = text.Split(' ');
        foreach (string w in wordArray)
        {
            _words.Add(new Word(w));
        }
    }

    // Method below to get and display the text in the word
    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + " ";
        foreach (Word w in _words)
        {
            result += w.GetDisplayText() + " ";
        }
        return result.Trim(); // Just to remove extra space at the end.
    }

    // Hide a number of random words i.e. for only words that
    // are currently visible but with only 1 parameter
    public void HideRandomWords(int numberToHide)
    {
        Random rnd = new Random();
        int hiddenCount = 0;

        // Create a list of words that are still visible
        List<Word> visibleWords = _words.FindAll(w => !w.IsHidden());

        while (hiddenCount < numberToHide && visibleWords.Count > 0)
        {
            int index = rnd.Next(visibleWords.Count);
            visibleWords[index].Hide();
            hiddenCount++;

            //Update visibleWords list
            visibleWords = _words.FindAll(w => !w.IsHidden());
        }
    }

    // Check if completely hidden by looping through all words
    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
                return false;
        }
        return true;
    }
}