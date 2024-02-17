class DuplicateWordRemoval
{
    static void Main()
    {
        Console.Write("Please enter a sentence: ");
        string sentence = Console.ReadLine();

        string[] words = sentence.Split();

        var uniqueWords = words.Distinct().OrderBy(word => word);

        Console.WriteLine("Nonduplicate words sorted in alphabetical order:");
        foreach (var word in uniqueWords)
        {
            Console.WriteLine(word);
        }
    }
}