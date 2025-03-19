using RetodDeProgramacion.Challenges;
using RetodDeProgramacion.Model;

string? answer;

//Classes used
FizzBuzz fz = new();
Anagram an = new();

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

do
{
    var isValid = false;
    var number = -1;
    
    do
    {
        showMenu(challengesCompleted);
        answer = Console.ReadLine();
        isValid = isValidResponse(answer);
    } while (isValid != true);
    
    Console.Clear();
    
    if (int.TryParse(answer, out number))
    {
        if (number == 0)
        {
            actionsMenu(0);
            break;
        }
        var oldAnswer = number;
        do
        {
            Console.Clear();
            actionsMenu(oldAnswer);
            Console.WriteLine();
            Console.WriteLine("What do you want now?");
            Console.WriteLine("1: Repeat this option");
            Console.WriteLine("2: Back to menu");
            Console.WriteLine("0: Total exit");
            answer = Console.ReadLine();
            Console.Clear();
        } while (answer == "1");
    }
    else
    {
        Console.WriteLine("The answer must be a specific number in the list " + answer);
        showMenu(challengesCompleted);
    }
} while (answer != "0");

void showMenu(List<ChallengeCompleted> challengesCompleted)
{
    //Options
    Console.WriteLine();
    Console.WriteLine("You have this options: ");
    Console.WriteLine();
    foreach(var challenge in challengesCompleted)
    {
        Console.WriteLine($"{challenge.number}) {challenge.name}. [{challenge.difficulty}]");
    }
}

void actionsMenu(int number)
{
    switch (number)
    {
        case 1:
            fz.doTheAction(challengesCompleted.Where(challenge => challenge.number == number ).ToList()[0]);
            break;
        case 2:
            an.doTheAction(challengesCompleted.Where(challenge => challenge.number == number).ToList()[0]);
            break;
        case 0:
            Console.WriteLine("Thanks for run my code c:");
            return;
        default:
            Console.WriteLine("The answer need to be in the list");
            showMenu(challengesCompleted);
            break;
    }
}

bool isValidResponse(string response)
{
    if (int.TryParse(response, out var number))
    {
        if (number < 0)
        {
            Console.Clear();
            Console.WriteLine("Please write an answer bigger than 0");
            return false;
        }
        else if (number > challengesCompleted.Max(ch => ch.number))
        {
            Console.Clear();
            Console.WriteLine("Please write a number in the answers range");
            return false;
        }
        else return true;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Please write a real number");
        return false;
    }
}