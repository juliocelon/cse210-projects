using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _words = new List<Word>();
        _reference = reference;
        List<string> words = new List<string>(text.Split(' '));

        foreach (string word in words)
        {
            Word myWord = new Word(word);
            _words.Add(myWord);
        }
    }

    public string GetDisplayText()
    {
        string text = $"{_reference.GetDisplayText()} ";
        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }
        return text;
    }

    public void HideRandomWords()
    {
        string answer = "";

        while (IsCompletelyHidden() == false && answer != "quit")
        {
            int maxWordsToHide = 3;
            int wordsToHide;
            int hiddenWordsCount = 0;

            // To control the number of words to hide per attempt
            if (GetAmountOfNoHiddenWords() <= maxWordsToHide)
                wordsToHide = 1;
            else
            {
                Random rnd = new Random();
                wordsToHide = rnd.Next(1, maxWordsToHide);
            }

            do
            {
                int randomIndex = 0;
                do
                {
                    Random rnd1 = new Random();
                    randomIndex = rnd1.Next(0, _words.Count);
                } while (_words[randomIndex].IsHidden()); // To keep looking for a word that has not been hidden
                _words[randomIndex].Hide();

                hiddenWordsCount++;

            } while (hiddenWordsCount < wordsToHide); // Loop to hide n words per user attempt.

            answer = Console.ReadLine();

            Console.Clear();

            if (answer != "quit")
                System.Console.WriteLine(GetDisplayText());


        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
                return false;
        }
        return true;
    }

    public int GetAmountOfNoHiddenWords()
    {
        int count = 0;
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
                count++;
        }
        return count;
    }

}