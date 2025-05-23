public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] splitWords = text.Split(" ");

        foreach (string wordText in splitWords)
        {
            Word word = new Word(wordText);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();

        List<string> wordTexts = new List<string>();
        foreach (Word word in _words)
        {
            wordTexts.Add(word.GetDisplayText());
        }

        return $"{referenceText} {string.Join(" ", wordTexts)}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }

        return true;
    }
}