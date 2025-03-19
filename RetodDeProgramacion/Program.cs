using RetodDeProgramacion.Challenges;
using RetodDeProgramacion.Model;

string answer;

//Classes used
FizzBuzz fz = new();
Anagram an = new();
do
{
    //Introduction to CLI
    Console.Clear();
    Console.WriteLine("***Welcome***");
    Console.WriteLine("##############");
    Console.WriteLine("This is only a proyect to practice logic in C#");
    Console.WriteLine("I'm doing this with JetBrains Rider in a MacBooc Air M2");
    
    //List of challenges
    List<ChallengeCompleted> challengesCompleted = new();
    challengesCompleted.Add(new ChallengeCompleted(1, "FizzBuzz", Difficulty.Fácil));
    challengesCompleted.Add(new ChallengeCompleted(2, "Anagram", Difficulty.Medio));
    challengesCompleted.Add(new ChallengeCompleted(0, "Exit", null));

    //Options
    Console.WriteLine();
    Console.WriteLine("You have this options: ");
    Console.WriteLine();
    foreach(var challenge in challengesCompleted)
    {
        Console.WriteLine($"{challenge.number}) {challenge.name}. [{challenge.difficulty}]");
    }
    
    answer = Console.ReadLine();
    
    Console.Clear();
    if (int.TryParse(answer, out int number))
    {
        
        switch (number)
        {
            case 1:
                fz.doTheAction(challengesCompleted.Where(challenge => challenge.number == number ).ToList()[0]);
                break;
            case 2:
                an.doTheAction(challengesCompleted.Where(challenge => challenge.number == number).ToList()[0]);
                break;
        }
    }
    else if (answer != "0")
    {
        return;
    }

    Console.WriteLine();
    Console.WriteLine("Do you wan't to continue?");
    Console.WriteLine("1: Yes");
    Console.WriteLine("0: No");
    answer = Console.ReadLine();
} while (answer != "0");

