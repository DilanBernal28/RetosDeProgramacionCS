using RetodDeProgramacion.Model;

namespace RetodDeProgramacion.Challenges;

public class Anagram : Challenge
{
    public override void DoTheAction(ChallengeCompleted challenge)
    {
        Console.WriteLine($"{challenge.Number} challenge: {challenge.Name}");
    }

    private void doAnagram()
    {
        
        //Instructions
        Console.WriteLine();
        Console.WriteLine("Please write two words");
        Console.WriteLine();
        
        Console.Write("First word: ");
        var palabra1 = Console.ReadLine();
        Console.Write("Second word: ");
        var palabra2 = Console.ReadLine();
        Console.WriteLine();
        
        //Error
        while (palabra1 == null || palabra2 == null || palabra1 == "" || palabra2 == "")
        {
            Console.WriteLine("The words can't be empty");
            Console.Write("Please write another words");
            palabra1 = Console.ReadLine();
            palabra2 = Console.ReadLine();
        }
        
        //Same words
        if (palabra1 == palabra2)
        {
            Console.WriteLine($"The answer is {false} because two equal words aren't an anagram");
            return;
        }
        var palabra1Ordenada = string.Concat(palabra1.OrderBy(c => c));
        var palabra2Ordenada = string.Concat(palabra2.OrderBy(c => c));
        Console.WriteLine(palabra1Ordenada != palabra2Ordenada ? "The words aren't an anagram": "The words are an anagram");
    }
}