using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;

        // Divide text into separate words
        string wordText = "";
        for (int i = 0; i < text.Length; i++)
        {
            // Check for the end of the word
            if (text[i] == ' ' && wordText != "")
            {
                // Add the word to _words
                Word word = new Word(wordText);
                _words.Add(word);

                wordText = "";
            }
            else
            {
                // Add letter to word
                wordText += text[i];
            }
        }
        // Add the last word
        Word lastWord = new Word(wordText);
        _words.Add(lastWord);
    }

    public void HideRandomWords(int numberToHide)
    {
        List<int> randIndexList = new List<int>();
        Random randomGenerator = new Random();
        int randIndex = -1;

        // Pick random indices
        for (int i = 0; i < numberToHide; i++)
        {
            // Repeat random picking until randIndex is a new and unhidden
            do
            {
                randIndex = randomGenerator.Next(0, _words.Count());
            } while (randIndexList.Contains(randIndex) || _words[randIndex].GetIsHidden());

            randIndexList.Add(randIndex);
            randIndex = -1;
        }

        // Hide the words at the random indices
        for (int i = 0; i < _words.Count(); i++)
        {
            if (randIndexList.Contains(i) && !_words[i].GetIsHidden())
            {
                _words[i].Hide();
            }
        }
    }

    public string GetDisplayText()
    {
        string displayText = "";

        // Add the reference to the displayed text
        displayText = _reference.GetDisplayText() + "\n";

        // Add each word to displayed text
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        // Remove whitespace at the end
        displayText = displayText.TrimEnd();

        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        // Returns false if any word is not hidden
        foreach (Word word in _words)
        {
            if (!word.GetIsHidden())
            {
                return false;
            }
        }

        return true;
    }
}