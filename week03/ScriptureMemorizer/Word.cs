public class Word
{
    private string _text;
    private string _hiddenText;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        string newText = "";
        foreach (char character in _text)
            newText += "_";
        _hiddenText = newText;
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
            return _hiddenText;
        else
            return _text;
    }

}