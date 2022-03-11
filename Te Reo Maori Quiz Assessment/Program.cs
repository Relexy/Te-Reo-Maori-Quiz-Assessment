
int score = 60;

// Member, Article, Achieve, Conclusion, Bottom, Ally, Spray, Carry, Jail, Shoot, Galaxy, Compact, Highway, Sacred, Tool
string[] words = new string[] {"mema", "atikara", "tutuki", "mutunga", "whakatakere", "haumi", "wairehu", "pakihere", "whare herehere", "pipihi", "ikarangi", "kiato", "huanui", "puaroa", "keteparaha"};

Console.WriteLine("This Is A '15 Level' Quiz To Increase Or Train Your Knowledge On The Te Reo Maori Language");
Console.WriteLine("You Are Going To Be Given One Word In Maori And You Are To Type From 4 Words Given That Are Translated In English");
Console.WriteLine("If You Guess The Right Translated Word You Are Given Points \nIf You Guess Incorrectly Your Chances Of Earning More Points Is Reduced\n\n");

Console.WriteLine("To Start The Quiz Type: 'start' ");
string start = Console.ReadLine();

while (start != "start")
{
    Console.WriteLine("Please Type 'start' To Begin The Quiz.");
    start = Console.ReadLine();
}

if (start == "start")
{
    Console.WriteLine($"Your First Word Is... {words[0]}");
    Console.WriteLine("A. Dilemma \nB. Memory \nC. Remember \nD. Member \n(Remember To Type The Word)");
    string guess = Console.ReadLine();
    while (guess == "Dilemma" || guess == "Memory" || guess == "Remember")
    {

            Console.WriteLine("Incorrect!");
            guess = Console.ReadLine();
            score--;
    }
    if (guess == "Member")
    {
            Console.WriteLine("Correct!");

    }
}
    Console.WriteLine($"Your Total Score Is: {score}/60");