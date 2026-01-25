public class Word
{
    private string _text;
    private bool _isHidden = false;

    public Word(string text)
    {
        _text = text;
    }

    private void Hide()
    {
        _isHidden = true;
    }
    private void Show()
    {
        _isHidden = false;
    }
    private bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        string displayedText = "";

        if (IsHidden())
        {
            for (int i = 0; i < _text.Length; i++)
            {
                displayedText += "_";
            }
        }
        else
        {
            displayedText = _text;
        }

        return displayedText;
    }
}