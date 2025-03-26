using RetodDeProgramacion.Model;
using SkiaSharp;

namespace RetodDeProgramacion.Challenges;

record AspectRatioInt(
    int Width,
    int Height);


record AspectRatioString(
    string LeftValue,
    string RightValue);
public class AspectRatio : Challenge
{
    public override void DoTheAction(ChallengeCompleted challenge)
    {
        Console.WriteLine($"{challenge.Number} challenge: {challenge.Name}");
        Console.WriteLine();

        CalculateAspectRatio().GetAwaiter().GetResult();
    }
    
    private static async Task<AspectRatioInt> GetImage(string url)
    {
        using HttpClient client = new();
        try
        {
            using Stream stream = await client.GetStreamAsync(url);
            using SKBitmap bitmap = SKBitmap.Decode(stream);
            Console.WriteLine($"{bitmap.Width}, {bitmap.Height}");
            return new AspectRatioInt(bitmap.Width, bitmap.Height);
        }
        catch (Exception e)
        {
            throw new Exception($"An exception ocurred: {e.Message}");
        }
    }

    private async Task CalculateAspectRatio()
    {
        Console.Clear();
        Console.Write("Please write here your URL to calculate the Aspect Ratio:");
        var answer = Console.ReadLine();
        while (answer == null || answer.Equals(string.Empty))
        {
            Console.Clear();
            Console.Write("You must to write an answer:");
            answer = Console.ReadLine();
        }

        try
        {
            var value = CalculateAspectRatio(await GetImage(answer));
            Console.WriteLine($"The aspect ratio is: {value.LeftValue}/{value.RightValue}");
        }
        catch (Exception e)
        {
            do
            {
                Console.WriteLine("Has ocurred an error loading the image, what do you wan't to do?");
                Console.WriteLine("1) Retry with the same link");
                Console.WriteLine("2) Retry with another link");
                Console.WriteLine("0) Exit and close");
                answer = Console.ReadLine();
            } while (answer == "1" && !answer.Equals(string.Empty));
            if (answer == "0") return;
            if (answer == "2")
            {
                CalculateAspectRatio();
            }
        }
    }
    
    private AspectRatioString CalculateAspectRatio(AspectRatioInt values)
    {
        PrimeNumbers pn = new();
        var width = values.Width;
        var height = values.Height;
        var listPrimeNumbers = pn.CalculateNPrimeNumbers(5);
        var i = 0;
        do
        {
            var primeNumber = listPrimeNumbers[i];
            if (width % primeNumber == 0 && height % primeNumber == 0)
            {
                width = width / primeNumber;
                height = height / primeNumber;
            }
            else
            {
                i++;
            }
        } while (i < listPrimeNumbers.Count);
        var value = new AspectRatioString(width.ToString(), height.ToString());
        
        return value;
    }
}