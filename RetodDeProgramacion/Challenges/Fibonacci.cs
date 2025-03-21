using RetodDeProgramacion.Model;

namespace RetodDeProgramacion.Challenges;

public class Fibonacci : Challenge
{
    public override void DoTheAction(ChallengeCompleted challenge)
    {
        Console.WriteLine($"{challenge.Number} challenge: {challenge.Name}");
        Console.WriteLine();
        DoFibonacci();
    }

    private void DoFibonacci()
    {
        Console.WriteLine($"1) {0}");
        Console.WriteLine($"2) {1}");
        var numberA = 0;
        var numberB = 1;
        var i = 3;
        while (i <= 50)
        {
            var numberC = numberA + numberB;
            numberA = numberB;
            numberB = numberC;
            Console.WriteLine($"{i}) {numberC}");
            i++;
        }
    }
}