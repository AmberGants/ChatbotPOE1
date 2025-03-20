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
        
        // 4 BASIC RESPONCE SYSTEM
        //5 VALIDATE INPUT
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
    }
    
}