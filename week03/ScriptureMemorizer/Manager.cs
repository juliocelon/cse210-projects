public class Manager
{
    private List<Scripture> _scriptures;
    public Manager()
    {
        _scriptures = new List<Scripture>();

        Reference reference1 = new Reference("Genesis", 1, 1);
        string text1 = "In the beginning God created the heavens and the earth.";
        Scripture scripture1 = new Scripture(reference1, text1);
        _scriptures.Add(scripture1);

        Reference reference2 = new Reference("Moroni", 10, 4, 5);
        string text2 = "And when ye shall receive these things, I would exhort you that ye would ask God, " +
        "the Eternal Father, in the name of Christ, if these things are not true; and if ye shall " +
        "ask with a sincere heart, with real intent, having faith in Christ, he will manifest the " +
        "truth of it unto you, by the power of the Holy Ghost." +
        "And by the power of the Holy Ghost ye may know the truth of all things.";
        Scripture scripture2 = new Scripture(reference2, text2);
        _scriptures.Add(scripture2);

        Reference reference3 = new Reference("John", 14, 15);
        string text3 = "If ye love me, keep my commandments.";
        Scripture scripture3 = new Scripture(reference3, text3);
        _scriptures.Add(scripture3);

        Reference reference4 = new Reference("D.&C.", 6, 36);
        string text4 = "Look unto me in every thought; doubt not, fear not.";
        Scripture scripture4 = new Scripture(reference4, text4);
        _scriptures.Add(scripture4);
    }

    public void Start()
    {
        Console.Clear();

        Random rnd = new Random();
        int randomIndex = rnd.Next(0, _scriptures.Count);

        System.Console.WriteLine(_scriptures[randomIndex].GetDisplayText());
        _scriptures[randomIndex].HideRandomWords();
    }
}