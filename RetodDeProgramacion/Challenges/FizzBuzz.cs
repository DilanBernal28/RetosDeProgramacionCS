using RetodDeProgramacion.Model;

namespace RetodDeProgramacion.Challenges;

public class FizzBuzz : Challenge
{
    public override void DoTheAction(ChallengeCompleted challenge)
    {
        Console.WriteLine($"{challenge.Number} challenge: {challenge.Name}");
        for (var i = 1; i <= 100; i++)
        {
            if (!isFizz(i) && !isBuzz(i))
            {
                Console.WriteLine(i);
            }
            else if (isFizz(num: i) && !isBuzz(i))
            {
                doFizz();
            }
            else if (!isFizz(i) && isBuzz(i))
            {
                doBuzz();
            }
            else if (isFizzBuzz(i))
            {
                doFizzBuzz();
            }
        }
    }


    private bool isFizz(int num)
    {
        return num % 3 == 0;
    }
    
    private bool isBuzz(int num)
    {
        return num % 5 == 0;
    }
    
    private bool isFizzBuzz(int num)
    {
        return isFizz(num) && isBuzz(num);
    }
    
    private void doFizz()
    {
        Console.WriteLine("Fizz");
    }
    private void doBuzz()
    {
        Console.WriteLine("Buzz");
    }
    private void doFizzBuzz()
    {
        Console.WriteLine("FizzBuzz");
    }
}