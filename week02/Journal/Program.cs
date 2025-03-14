/*
Showing Creativity and Exceeding Requirements

1. Think of other problems that keep people from writing in their journal and address one of those.
    > I added an option to write without a prompt. Instead, users can enter a Title for their journal entry. 
      This provides more flexibility.
2. Save other information in the journal entry.
    > I updated the Entry class to include the time of the entry and an entry type field, 
      allowing users to specify whether the entry is based on a prompt or a custom title.
3. Improve the process of saving and loading to save as a .csv file that could be opened in Excel 
   (make sure to account for quotation marks and commas correctly in your content.
   > The program save the information in a file with format .csv, ensuring proper formatting for Excel
     compatibility (the file extension must be specified). Commas in the content are replaced with dashes 
     to prevent formatting issues, and dashes are converted back to commas when retrieving the information 
     from the file.
     
*/
class Program
{
    static void Main(string[] args)
    {
        JournalManager journalManager = new JournalManager();
        journalManager.Start();
    }
}