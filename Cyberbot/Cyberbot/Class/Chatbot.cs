using System;
using System.Threading;

public class Chatbot
{
    private User user;

    public Chatbot(User user)
    {
        this.user = user;
    }

    public void Start()
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nYou: ");
            Console.ResetColor();

            string input = Console.ReadLine()?.ToLower();

            if (string.IsNullOrWhiteSpace(input))
            {
                TypeText("Please enter something.");
                continue;
            }

            if (input == "exit")
            {
                TypeText($"Goodbye {user.Name}! Stay safe online.");
                break;
            }

            Respond(input);
        }
    }

    public void Respond(string input)
    {
        if (input.Contains("how are you"))
        {
            TypeText("I'm doing great and ready to help!");
        }
        else if (input.Contains("purpose"))
        {
            TypeText("I help South Africans stay safe from cyber threats.");
        }
        else if (input.Contains("phishing"))
        {
            TypeText("Phishing scams often pretend to be banks like FNB or Capitec. Never click suspicious links.");
        }
        else if (input.Contains("recognize") || input.Contains("detect"))
        {
            TypeText("Phishing messages often have suspicious links, poor grammar, or urgent requests.");
        }
        else if (input.Contains("protect"))
        {
            TypeText("Always verify links and never share sensitive information online.");
        }
        else if (input.Contains("clicked") || input.Contains("fall for"))
        {
            TypeText("If you clicked a phishing link, change your passwords immediately and contact your bank.");
        }
        else if (input.Contains("spear"))
        {
            TypeText("Spear phishing targets specific individuals using personalised messages.");
        }
        else if (input.Contains("whaling"))
        {
            TypeText("Whaling targets executives with highly convincing phishing emails.");
        }
        else if (input.Contains("password"))
        {
            TypeText("Use strong passwords with letters, numbers, and symbols. Avoid reusing passwords.");
        }
        else if (input.Contains("safe browsing"))
        {
            TypeText("Always check for HTTPS and avoid unknown websites.");
        }
        else if (input.Contains("two factor") || input.Contains("2fa"))
        {
            TypeText("Enable two-factor authentication for extra security.");
        }
        else if (input.Contains("report"))
        {
            TypeText("Report phishing to your bank or SABRIC in South Africa.");
        }
        else if (input.Contains("antivirus") || input.Contains("security software"))
        {
            TypeText("Install trusted antivirus software to protect your device.");
        }
        else
        {
            TypeText("I didn't understand that. Try asking about phishing or cybersecurity.");
        }
    }

    private void TypeText(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;

        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(20);
        }

        Console.WriteLine();
        Console.ResetColor();
    }
}