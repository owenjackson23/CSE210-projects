public class Word
{
    private string _text;
    private bool _isHidden = false;

    public Word(string text)
    {
        _text = text;
    }

    // setters for _isHidden
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }

    // getter for _isHidden
    public bool GetIsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        string displayedText = "";

        // A list of characters to never hide
        List<char> neverHideChars = new List<char>
        {
            '!', '(', ')', '-', '"',
            ',', '.', '?', ' '
        };

        if (_isHidden)
        {
            // Replaces letters with underscores
            foreach (char letter in _text)
            {
                if (neverHideChars.Contains(letter))
                {
                    displayedText += letter;
                }
                else
                {
                    displayedText += "_";
                }
            }
        }
        else
        {
            displayedText = _text;
        }

        return displayedText;
    }
}