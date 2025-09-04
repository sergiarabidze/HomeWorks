
using System;

class Program
{
    static void Main()
    {
        var word = "gamrjoba";
        LetterCounter(word);


    }

    static void LetterCounter(String word)
    {
        Dictionary<char, int> letterCounts = new Dictionary<char, int>();

        for (int i = 0; i < word.Length; i++)
        {
            char letter = word[i];
            if()
            letterCounts[letter]++;

        }
        foreach (var item in letterCounts)
        {
            Console.WriteLine(item.Key + " - " + item.Value);
        }
    }
}
