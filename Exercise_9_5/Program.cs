using System.Collections.Generic;
using System.Linq;
using System;
using System.Diagnostics.Metrics;

public class program
{
    static void Main(string[] args)
    {
        List<char> letterList = new List<char>();
        Random rand = new Random();

        for (int i = 0; i < 30; i++)
        {
            char letter = (char)rand.Next(65, 91);
            letterList.Add(letter);
        }

        // Display random letters
        Console.WriteLine("Random list of letters:");
        foreach (char letter in letterList)
        {
            Console.Write(letter + "\n");
        }
        Console.WriteLine();

        //Use LINQ to sort list in ascending order
        var ascendingList = letterList.OrderBy(x => x);

        //Display letters sorted in ascending order
        Console.Write("Random letters sorted in ascending order: \n");
        foreach (char letter in ascendingList)
        {
            Console.Write(letter + "\n");
        }

        //Use LINQ to sort list in descending order
        var descendingList = letterList.OrderByDescending(x => x);

        //Display letters sorted in descending order
        Console.Write("\nRandom letters sorted in descending order: \n");
        foreach (char letter in descendingList)
        {
            Console.Write(letter + "\n");
        }

        //Use LINQ to get nonduplicate values
        var uniqueList = descendingList.Distinct();

        // Display list in descending order without duplicates
        Console.WriteLine("\nNonduplicate list sorted in descending order: ");
        foreach (var word in uniqueList)
        {
            Console.WriteLine(word);
        }
    }
}