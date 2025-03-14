public class Entry
{
    public string _date;
    public string _time;
    public string _promptOrTitleText;
    public string _entryText;
    public string _entryType;

    public string Display()
    {
        if(_entryType == "prompt")
            return $"Date: {_date} - Time: {_time} - Prompt: {_promptOrTitleText}\n> {_entryText}";
        else
            return $"Date: {_date} - Time: {_time} - Title: {_promptOrTitleText}\n> {_entryText}";
    }

    public string FormatForFileSave()
    {
        // Replace commas with dashes to prevent issues in the CSV file
        return $"{_date},{_time},{_entryType},{_promptOrTitleText.Replace(",","-")},{_entryText.Replace(",","-")}";
    }
}