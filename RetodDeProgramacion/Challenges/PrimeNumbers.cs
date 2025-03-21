using RetodDeProgramacion.Model;

namespace RetodDeProgramacion.Challenges;

public class PrimeNumbers : Challenge
{
    public override void doTheAction(ChallengeCompleted challenge)
    {
        Console.WriteLine($"{challenge.Number} challenge: {challenge.Name}");
        DoPrimeNumbers();
    }

    private void DoPrimeNumbers()
    {
        for (var i = 2; i <= 100; i++)
        {
            var value = evaluatePrimeNumber(number:i);
            if (value)
            {
                Console.WriteLine(i);
            }
        }
    }

    private bool evaluatePrimeNumber(int number)
    {
        bool value;
        var i = 1;
        var cantity = 0;
        value = i == number;
        if (i < number)
        {
            while (i <= number/2)
            {
                if (number % i == 0) cantity++;
                i++;
            }
        }

        value = cantity > 1;
        return !value;
    }
}