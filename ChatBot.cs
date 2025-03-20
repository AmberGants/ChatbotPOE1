class Program 
{
    static void Main(strings[] args) 
    {
        //1 VOICE GREETING
        //2 IMAGE DISPLAY
        //Creating cyctbersecurity-themed sysmbol
        Console.WriteLine("***************************************");
        Console.WriteLine("*                                     *");
        Console.WriteLine("*     CYBERSECURIY AWARENESS BOT      *");
        Console.WriteLine("*    I'm here to help you stay safe   *");
        Console.WriteLine("*              online.                *");
        Console.WriteLine("*                                     *");
        Console.WriteLine("***************************************");

        StartChatBot();
        
       
        
        //6 ENHANCED CONSOLE UI WITH VISUAL ELEMENTS 
    }
//3 TEXT-BASED GREETING AND USER INTERACTION
    static void StartChatBot()
    {
        //Ask the user for their name and personalise responses using the name
    Console.WriteLine("What is your name?");
    String name = Console.ReadLine();
    Console.WriteLine($"Welcome {name} to the Cybersecurity Awareness Bot. \n WRITE quit TO EXIT");

    while (true)
    {
    Console.WriteLine($"{name} what would you like to know?");
    string userInput = Console.ReadLine().ToLower();

    if (userInput.Equals("what can i ask you about?"))
    {
        Console.WriteLine("You can ask me about password safety, phishing, and safe browsing.");
    }

    else if (userInput.Equals("quit"))
    {
        Console.WriteLine($"Thank you for chatting {name}! Stay safe online.");
    }

    else if (string.IsNullOrWhiteSpace(userInput))
    {
        Console.WriteLine("I didn't quite understand that. Could you rephrase?");
        continue;
    }
    else if (userInput.Equals($"how are you {name}?"))
    {
        Console.WriteLine("I am just program, but Im here to help you!.");
    }
    // 4 BASIC RESPONCE SYSTEM & 5 VALIDATE INPUT
        //Questions a user might ask
    switch (userInput)
    {
        case "what's your purpose?":
            Console.WriteLine("You can ask me about password safety, phishing, and safe browsing.");
         break;
        case "how can i create a strong password?":
            Console.WriteLine("Use a mix of letters, numbers, and symbols, and avoid using easily guessable information.");
            break;
        case "what is phishing and how can i avoid it?":
            Console.WriteLine("Phishing is a scam where attackers impersonate legitimate entities to steal personal information. Always verify the source before clicking links.");
            break;
        case "how can i browse the internet safely?":
            Console.WriteLine("Use secure websites (look for HTTPS), avoid public Wi-Fi for sensitive transactions, and keep your software updated.");
            break;
        case "tell me about password safety":
            Console.WriteLine("Always use strong passwords, change them regularly, and never share them.");
            break;
        case "what is phishing?":
            Console.WriteLine("Phishing is a method used by cybercriminals to trick you into giving them your personal information.");
            break;
        case "how to browse safely?":
            Console.WriteLine("Use secure websites (https), avoid public Wi-Fi for sensitive transactions, and keep your software updated.");
            break;
        default:
            Console.WriteLine("I didn't quite understand that. Could you rephrase?");
            break;
    }

}
    }
    
}