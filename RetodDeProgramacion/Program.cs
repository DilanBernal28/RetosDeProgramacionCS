using RetodDeProgramacion.Challenges;
using RetodDeProgramacion.Model;

string? answer;

//Classes used
FizzBuzz fz = new();
Anagram an = new();
Fibonacci fb = new();
PrimeNumbers pn = new();
PolygonArea pa = new();

//Introduction to CLI
Console.Clear();
Console.WriteLine("***Welcome***");
Console.WriteLine("##############");
Console.WriteLine("This is only a proyect to practice logic in C#");
Console.WriteLine("I'm doing this with JetBrains Rider in a MacBooc Air M2");

//List of challenges
List<ChallengeCompleted> challengesCompleted = new();
challengesCompleted.Add(new ChallengeCompleted(1, "Fizz Buzz", Difficulty.Fácil));
challengesCompleted.Add(new ChallengeCompleted(2, "Anagram", Difficulty.Medio));
challengesCompleted.Add(new ChallengeCompleted(3, "Fibonacci", Difficulty.Difícil));
challengesCompleted.Add(new ChallengeCompleted(4, "Prime Numbers", Difficulty.Medio));
challengesCompleted.Add(new ChallengeCompleted(5, "Polygon Area", Difficulty.Fácil));

challengesCompleted.Add(new ChallengeCompleted(0, "Exit", null));

do
{
    bool isValid;
    var number = -1;
    
    do
    {
        ShowMenu();
        answer = Console.ReadLine();
        isValid = IsValidResponse(answer);
    } while (isValid != true);
    
    Console.Clear();
    
    if (int.TryParse(answer, out number))
    {
        if (number == 0)
        {
            ActionsMenu(0);
            break;
        }
        var oldAnswer = number;
        do
        {
            Console.Clear();
            ActionsMenu(oldAnswer);
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
        ShowMenu();
    }
} while (answer != "0");

//Aditional Functions
void ShowMenu()
{
    //Options
    Console.WriteLine();
    Console.WriteLine("You have this options: ");
    Console.WriteLine();
    foreach(var challenge in challengesCompleted)
    {
        Console.WriteLine($"{challenge.Number}) {challenge.Name}. [{challenge.Difficulty}]");
    }
}

void ActionsMenu(int number)
{
    switch (number)
    {
        case 1:
            fz.DoTheAction(challengesCompleted.First(ch => ch.Number == number));
            break;
        case 2:
            an.DoTheAction(challengesCompleted.First(ch => ch.Number == number));
            break;
        case 3:
            fb.DoTheAction(challengesCompleted.First(ch => ch.Number == number));
            break;
        case 4:
            pn.DoTheAction(challengesCompleted.First(ch => ch.Number == number));
            break;
        
        case 5:
            pa.DoTheAction(challengesCompleted.First(ch => ch.Number == number));
            break;
        case 0:
            Console.WriteLine("Thanks for run my code c:");
            return;
        default:
            Console.WriteLine("The answer need to be in the list");
            ShowMenu();
            break;
    }
}

bool IsValidResponse(string? response)
{
    if (response == null)
    {
        Console.Clear();
        Console.WriteLine("Please Write a real answer");
        return false;
    }
    if (int.TryParse(response, out var number))
    {
        if (number < 0)
        {
            Console.Clear();
            Console.WriteLine("Please write an answer bigger than 0");
            return false;
        }
        else if (number > challengesCompleted.Max(ch => ch.Number))
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