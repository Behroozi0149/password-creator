try
{
    var name = "user";
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Hello. This program creates a password for you");
    Console.Write("Would you like to enter your name?");
    var answer = Console.ReadLine();
    if (answer == "yes")
    {
        Console.Write("enter your name:");
        name = Console.ReadLine();
    }
    else if (answer == "no")
    {
        Console.WriteLine("ok");
    }
    else
    {
        Console.WriteLine("Please remember to give the correct answer next time");
    }
    string[] word = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
    string[] wordcaptal = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
    string[] mark = { "!", "@", "#", "$", "%", "^", "&", "*", "()", "(", ")", "-", "_", "+", "=", "?", "|", "/", ">", "<", ",", ".", "<>", "!?", "@#", "~" };
    var rnd = new Random();
    Console.WriteLine("I am creating your password");
    Console.Write("your password:");
    Console.Write($"{name}_");
    for (int i = 0; i < 2; i++)
    {
        Console.Write(word[rnd.Next(word.Length)]);
        Console.Write(wordcaptal[rnd.Next(wordcaptal.Length)]);
        Console.Write(rnd.Next(0, 100));
        Console.Write(mark[rnd.Next(mark.Length)]);
    }
    Console.WriteLine();
    Console.WriteLine($"goodbay {name}");
    Console.ResetColor();
}
catch
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Error, please run the program again and provide more detailed information.");
    Console.ResetColor();
}