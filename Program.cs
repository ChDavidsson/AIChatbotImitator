namespace AIChatbotImitator;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        string[] svar =
        {
            "Intressant fråga... svaret finns inom dig själv 🤖",
            "Det vet bara framtiden!",
            "Hmm... jag måste tänka på det.",
            "Svaret är 42!",
            "Jag återkommer när jag har tänkt klart."
        };

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Hej! Jag är en AI-chatbot. Ställ mig en fråga:");
        string question = Console.ReadLine()!;
        int slump = random.Next(svar.Length);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(svar[slump]);
    }
}
