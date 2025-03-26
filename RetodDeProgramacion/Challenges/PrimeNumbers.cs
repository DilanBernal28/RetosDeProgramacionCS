using RetodDeProgramacion.Model;

namespace RetodDeProgramacion.Challenges;

public class PrimeNumbers : Challenge
{
    public override void DoTheAction(ChallengeCompleted challenge)
    {
        Console.WriteLine($"{challenge.Number} challenge: {challenge.Name}");
        DoPrimeNumbers();
    }

    private void DoPrimeNumbers()
    {
        for (var i = 2; i <= 100; i++)
        {
            var value = EvaluateNumber(number:i);
            if (value)
            {
                Console.WriteLine(i);
            }
        }
    }

    public List<int>? CalculateNPrimeNumbers(int n)
    {
        List<int> primeNumbers = new();
        var number = 2;
        var correctLoop = 0;
        do
        {
            var value = EvaluateNumber(number);
            if (value)
            {
                primeNumbers.Add(number);
                correctLoop++;
            }
            number++;
        } while (correctLoop < n);
        return primeNumbers.Count > 0 ? primeNumbers : null;
    }

    private bool EvaluateNumber(int number)
    {
        bool value;
        var i = 1;
        var cantity = 0;
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