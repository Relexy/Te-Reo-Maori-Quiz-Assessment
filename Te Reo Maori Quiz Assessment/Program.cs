
int score = 0;
bool validGuess = false;
bool gameFinish = false;
int quizNum = 0;

// Member, Article, Achieve, Conclusion, Bottom, Ally, Spray, Carry, Jail, Shoot, Galaxy, Compact, Highway, Sacred, Tool
string[] words = new string[] { "mema", "atikara", "tutuki", "mutunga", "whakatakere", "haumi", "wairehu", "pakihere", "whare herehere", "pipihi", "ikarangi", "kiato", "huanui", "puaroa", "keteparaha" };
string[] answers = new string[] { "Member", "Article", "Achieve", "Conclusion", "Bottom", "Ally", "Spray", "Carry", "Jail", "Shoot", "Galaxy", "Compact", "Highway", "Sacred", "Tool" };
string[] optionsQ1 = new string[] { "dilemma", "memory", "remember"};

for (int i = 0; i < optionsQ1.Length; i++)
{
    optionsQ1[i].ToLower();
}
for (int i = 0; i < answers.Length; i++)
{
    answers[i] = answers[i].ToLower();
    Console.WriteLine(answers[i]);
}

Console.WriteLine("This Is A '15 Level' Quiz To Increase Or Train Your Knowledge On The Te Reo Maori Language");
Console.WriteLine("You Are Going To Be Given One Word In Maori And You Are To Type From 4 Words Given That Are Translated In English");
Console.WriteLine("If You Guess The Right Translated Word You Are Given Points \nIf You Guess Incorrectly Your Points Is Reduced\n\n");

Console.WriteLine("To Start The Quiz Type: 'start' ");
string start = Console.ReadLine();

while (start.ToLower() != "start")
{
    Console.WriteLine("Please Type 'start' To Begin The Quiz.");
    start = Console.ReadLine();
}

if (start.ToLower() == "start")
{
    Console.WriteLine($"Your First Word Is... {words[quizNum]}");
    Console.WriteLine($"A. {optionsQ1[0]} \nB. {optionsQ1[1]} \nC. {optionsQ1[2]} \nD. {answers[0]} \n(Remember To Type The Word)");
 


    while (gameFinish != true)
    {
        string guess = Console.ReadLine();
        guess = guess.ToLower();
        for (int i = 0; i < optionsQ1.Length; i++)
        {
            if (guess == optionsQ1[i].ToLower())
            {
                validGuess = true;
            }
        }
        if (validGuess != true)
        {
            Console.WriteLine("Please Type One Of The Following Words");

        }
        else if (guess != answers[quizNum])
        {
            Console.WriteLine("Incorrect!");
            score--;
            if (score < 0)
            {
                score = 0;
            }

        }
        if (guess == answers[quizNum])
        {
            Console.WriteLine("Correct!");
            score += 2;
            quizNum++;

            switch (quizNum)
            {
                case  1:
                Console.WriteLine($"Your Second Word Is... {words[quizNum]}");
                Console.WriteLine($"A. {optionsQ1[0]} \nB. {optionsQ1[1]} \nC. {optionsQ1[2]} \nD. {optionsQ1[3]} \n(Remember To Type The Word)");
                    break;

                case 2:
                Console.WriteLine($"Your Second Word Is... {words[quizNum]}");
                Console.WriteLine($"A. {optionsQ1[0]} \nB. {optionsQ1[1]} \nC. {optionsQ1[2]} \nD. {optionsQ1[3]} \n(Remember To Type The Word)");
                    break;
            }
        }
        validGuess = false;
    }

    Console.WriteLine($"Your Total Score Is: {score}/30");
}