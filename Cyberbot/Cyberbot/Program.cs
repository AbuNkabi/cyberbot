using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Cybersecurity Bot";

        // PLAY AUDIO
        AudioPlayer.PlayGreeting();

        // ASCII ART
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(@"
========================================
   CYBERSECURITY AWARENESS BOT 🇿🇦
========================================
");
        Console.ResetColor();

        // USER NAME
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            name = "User";
        }

        User user = new User { Name = name };

        Console.WriteLine($"\nWelcome, {user.Name}!");

        // 👉 UPDATED: Show what user can ask
        Console.WriteLine("You can ask me about:");
        Console.WriteLine("- Phishing scams");
        Console.WriteLine("- Password safety");
        Console.WriteLine("- Safe browsing");
        Console.WriteLine("- Two-factor authentication (2FA)");
        Console.WriteLine("- Reporting cybercrime");
        Console.WriteLine("\nType 'exit' to quit.\n");

        // START CHATBOT
        Chatbot bot = new Chatbot(user);
        bot.Start();
    }
}