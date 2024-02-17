class DuplicateWordRemoval
{
    static void Main()
    {
        Console.Write("Please enter a sentence: ");
        string sentence = Console.ReadLine();

        Console.WriteLine("\nUser entered sentence: \n" + sentence);
        string[] words = sentence.Split();

        var uniqueWords = words.Distinct().OrderBy(word => word);

        Console.WriteLine("\nNonduplicate words sorted in alphabetical order: ");
        foreach (var word in uniqueWords)
        {
            Console.WriteLine(word);
        }
    }
}