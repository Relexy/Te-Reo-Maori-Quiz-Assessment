/* Te Reo Maori Quiz Assessment */


int score = 0;
bool validGuess = false;
int quizNum = 0;

// words = Maori Words | answers = Correct Word | options = Filler Words
string[] words = new string[] { "mema", "atikara", "tutuki", "mutunga", "whakatakere", "haumi", "wairehu", "pakihere", "whare herehere", "pipihi", "ikarangi", "kiato", "huanui", "puaroa", "keteparaha", "rongo ā-puku", "kaitākaro", "wātaka", "mohoaotanga", "whakamaru", "tūruhi", "puna torotī", "kukuwhatanga", "konutai", "kōwhiri", "huritau", "ringatoi", "kaimātakitaki", "wharekai", "rangirua"};//Ambiguous
string[] answers = new string[] { "member", "article", "achieve", "conclusion", "bottom", "ally", "spray", "carry", "jail", "shoot", "galaxy", "compact", "highway", "sacred", "tool", "instinct", "player", "calendar", "isolation", "protection", "tourist", "fountain", "evolution", "sodium", "choose", "anniversary", "artist", "audience", "coast", "ambiguous"};
string[] options = new string[] { "dilemma", "memory", "remember", "attic", "attend", "athletic", "agile", "trolley", "trust", "measure", "mountain", "mechanic", "withdraw", "waiter", "builder", "heat", "helmet", "helping", "wrestle", "wardrobe", "wine", "positivity", "contain", "clapping", "mansion", "construction", "mall", "peeking", "produce", "liar", "inclusive", "irony", "feast", "know", "kidney", "prestige", "headquarters", "hardship", "harbor", "sacrifice", "smash", "portal", "container", "kitchen", "position", "rollercoaster", "incorrect", "oranges", "kite", "breakfast", "cutting", "wildfire", "waxing", "boring", "mohawk", "mountain", "mahogany", "course", "cake", "confront", "towards", "torture", "tournament", "plantation", "pumpkin", "tuna", "coconut", "commotion", "kill", "corner", "cornfield", "tie", "quickly", "coughing", "cigarette", "hurriedly", "furiously", "close", "ringtone", "ring", "reform", "constructing", "repetition", "conversation", "thank", "tax", "technique", "umbrella", "waterfall", "recording"};


Console.WriteLine("This Is A '15 Level' Quiz To Increase Or Train Your Knowledge On The Te Reo Maori Language");
Console.WriteLine("You Are Going To Be Given One Word In Maori And You Are To Type From 4 Words Given That Are Translated In English");
Console.WriteLine("If You Guess The Right Translated Word You Are Given Points \nIf You Guess Incorrectly Your Points Is Reduced\n\n");

Console.WriteLine("If You Wish To Stop Anytime During The Quiz Type '-1'");
Console.WriteLine("To Start The Quiz Type: 'start' ");
string start = Console.ReadLine();

while (start.ToLower() != "start")
{
    Console.WriteLine("Please Type 'start' To Begin The Quiz.");
    start = Console.ReadLine();
}

if (start.ToLower() == "start")
{
    Console.WriteLine($"Your 1st Word Is... {words[quizNum]}");
    Console.WriteLine($"A. {options[0]} \nB. {options[1]} \nC. {options[2]} \nD. {answers[0]} \n(Remember To Type The Word)");
 


    while (quizNum != 15)
    {
        string guess = Console.ReadLine();
        guess = guess.ToLower();
        for (int i = 0; i < options.Length; i++) // Loops through the options Array With Index i
        {
            for (int j = 0; j < answers.Length; j++) // Loops through the answers Array With Index j
            {
                // Accepts Input If It's A Word In answers, options Array, or -1
                if (guess == answers[j].ToLower() || guess == options[i].ToLower() || guess == "-1")
                {
                    validGuess = true;
                }
            }
        }
        if (validGuess != true)
        {
            Console.WriteLine("Please Type One Of The Following Words"); // If Input Isn't A Word In answers, options Array, or = -1

        }
        else if (guess == "-1")
        {
            break; // Ends Quiz When Input = -1
        }
        else if (guess != answers[quizNum]) // If It's A Valid Input But Not Answer
        {
            Console.WriteLine("Incorrect!"); 
            score--;
            if (score < 0)
            {
                score = 0; // Score Won't Go Less Than 0
            }

        }
        if (guess == answers[quizNum])
        {
            Console.WriteLine("Correct!\n");
            score += 2;
            quizNum++;

            switch (quizNum)
            {
                case  1:
                Console.WriteLine($"Your 2nd Word Is... {words[quizNum]}");
                Console.WriteLine($"A. {options[3]} \nB. {answers[1]} \nC. {options[4]} \nD. {options[5]} \n(Remember To Type The Word)");
                    break;

                case 2:
                Console.WriteLine($"Your 3rd Word Is... {words[quizNum]}");
                Console.WriteLine($"A. {options[6]} \nB. {answers[2]} \nC. {options[7]} \nD. {options[8]} \n(Remember To Type The Word)");
                    break;

                case 3:
                    Console.WriteLine($"Your 4th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {options[9]} \nB. {answers[3]} \nC. {options[10]} \nD. {options[11]} \n(Remember To Type The Word)");
                    break;

                case 4:
                    Console.WriteLine($"Your 5th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {options[12]} \nB. {options[13]} \nC. {options[14]} \nD. {answers[4]} \n(Remember To Type The Word)");
                    break;

                case 5:
                    Console.WriteLine($"Your 6th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {options[15]} \nB. {answers[5]} \nC. {options[16]} \nD. {options[17]} \n(Remember To Type The Word)");
                    break;

                case 6:
                    Console.WriteLine($"Your 7th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {answers[6]} \nB. {options[18]} \nC. {options[19]} \nD. {options[20]} \n(Remember To Type The Word)");
                    break;

                case 7:
                    Console.WriteLine($"Your 8th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {options[21]} \nB. {answers[7]} \nC. {options[22]} \nD. {options[23]} \n(Remember To Type The Word)");
                    break;

                case 8:
                    Console.WriteLine($"Your 9th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {options[24]} \nB. {options[25]} \nC. {options[26]} \nD. {answers[8]} \n(Remember To Type The Word)");
                    break;

                case 9:
                    Console.WriteLine($"Your 10th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {answers[9]} \nB. {options[27]} \nC. {options[28]} \nD. {options[29]} \n(Remember To Type The Word)");
                    break;

                case 10:
                    Console.WriteLine($"Your 11th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {options[30]} \nB. {answers[10]} \nC. {options[31]} \nD. {options[32]} \n(Remember To Type The Word)");
                    break;

                case 11:
                    Console.WriteLine($"Your 12th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {options[33]} \nB. {options[34]} \nC. {answers[11]} \nD. {options[35]} \n(Remember To Type The Word)");
                    break;

                case 12:
                    Console.WriteLine($"Your 13th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {answers[12]} \nB. {options[36]} \nC. {options[37]} \nD. {options[38]} \n(Remember To Type The Word)");
                    break;

                case 13:
                    Console.WriteLine($"Your 14th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {options[39]} \nB. {options[40]} \nC. {options[41]} \nD. {answers[13]} \n(Remember To Type The Word)");
                    break;

                case 14:
                    Console.WriteLine($"Your 15th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {options[42]} \nB. {answers[14]} \nC. {options[43]} \nD. {options[44]} \n(Remember To Type The Word)");
                    break;
            }
        }
        validGuess = false;
    }

    Console.WriteLine($"Your Total Score Is: {score}/30\n");
}

// Quiz Continues
Console.WriteLine("This Is The End Of The '15 Level' Te Reo Maori Langauage Quiz.\n");
Console.WriteLine("If You Wish To Hone Your Knowledge Of The Te Reo Maori Language With Another '15 Levels' Type 'start'. ");
Console.WriteLine("If You Want To Exit Now Or Anytime During The Levels Type '-1'.\n");
Console.WriteLine("To Start The Quiz Type: 'start' ");
start = Console.ReadLine();

while (start.ToLower() != "start")
{
    Console.WriteLine("Please Type 'start' To Begin The Quiz.");
    start = Console.ReadLine();
}

if (start.ToLower() == "start")
{
    Console.WriteLine($"Your 16th Word Is... {words[quizNum]}");
    Console.WriteLine($"A. {options[45]} \nB. {answers[15]} \nC. {options[46]} \nD. {options[47]} \n(Remember To Type The Word)");



    while (quizNum != 30)
    {
        string guess = Console.ReadLine();
        guess = guess.ToLower();
        for (int i = 0; i < options.Length; i++) // Loops through the options Array With Index i
        {
            for (int j = 0; j < answers.Length; j++) // Loops through the answers Array With Index j
            {
                // Accepts Input If It's A Word In answers, options Array, or -1
                if (guess == answers[j].ToLower() || guess == options[i].ToLower() || guess == "-1")
                {
                    validGuess = true;
                }
            }
        }
        if (validGuess != true)
        {
            Console.WriteLine("Please Type One Of The Following Words"); // If Input Isn't A Word In answers, options Array, or = -1

        }
        else if (guess == "-1")
        {
            break; // Ends Quiz When Input = -1
        }
        else if (guess != answers[quizNum]) // If It's A Valid Input But Not Answer
        {
            Console.WriteLine("Incorrect!");
            score--;
            if (score < 0)
            {
                score = 0; // Score Won't Go Less Than 0
            }

        }
        if (guess == answers[quizNum])
        {
            Console.WriteLine("Correct!\n");
            score += 2;
            quizNum++;

            switch (quizNum)
            {
                case 15:
                    Console.WriteLine($"Your 17th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {answers[16]} \nB. {options[48]} \nC. {options[49]} \nD. {options[50]} \n(Remember To Type The Word)");
                    break;

                case 16:
                    Console.WriteLine($"Your 18th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {answers[17]} \nB. {options[51]} \nC. {options[52]} \nD. {options[53]} \n(Remember To Type The Word)");
                    break;

                case 17:
                    Console.WriteLine($"Your 19th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {options[54]} \nB. {options[55]} \nC. {options[56]} \nD. {answers[18]} \n(Remember To Type The Word)");
                    break;

                case 18:
                    Console.WriteLine($"Your 20th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {options[57]} \nB. {options[58]} \nC. {answers[19]} \nD. {options[59]} \n(Remember To Type The Word)");
                    break;

                case 19:
                    Console.WriteLine($"Your 21st Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {options[60]} \nB. {answers[20]} \nC. {options[61]} \nD. {options[62]} \n(Remember To Type The Word)");
                    break;

                case 20:
                    Console.WriteLine($"Your 22nd Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {answers[21]} \nB. {options[63]} \nC. {options[64]} \nD. {options[65]} \n(Remember To Type The Word)");
                    break;

                case 21:
                    Console.WriteLine($"Your 23rd Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {options[66]} \nB. {answers[22]} \nC. {options[67]} \nD. {options[68]} \n(Remember To Type The Word)");
                    break;

                case 22:
                    Console.WriteLine($"Your 24th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {options[69]} \nB. {options[70]} \nC. {options[71]} \nD. {answers[23]} \n(Remember To Type The Word)");
                    break;

                case 23:
                    Console.WriteLine($"Your 25th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {answers[24]} \nB. {options[72]} \nC. {options[73]} \nD. {options[74]} \n(Remember To Type The Word)");
                    break;

                case 24:
                    Console.WriteLine($"Your 26th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {options[75]} \nB. {answers[25]} \nC. {options[76]} \nD. {options[77]} \n(Remember To Type The Word)");
                    break;

                case 25:
                    Console.WriteLine($"Your 27th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {options[78]} \nB. {options[79]} \nC. {answers[26]} \nD. {options[80]} \n(Remember To Type The Word)");
                    break;

                case 26:
                    Console.WriteLine($"Your 28th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {answers[27]} \nB. {options[81]} \nC. {options[82]} \nD. {options[83]} \n(Remember To Type The Word)");
                    break;

                case 27:
                    Console.WriteLine($"Your 29th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {options[84]} \nB. {options[85]} \nC. {options[86]} \nD. {answers[28]} \n(Remember To Type The Word)");
                    break;

                case 28:
                    Console.WriteLine($"Your 30th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {options[87]} \nB. {answers[29]} \nC. {options[88]} \nD. {options[89]} \n(Remember To Type The Word)");
                    break;
            }
        }
        validGuess = false;
    }
}
else if (start.ToLower() == "-1")
{
    quizNum = 30;
}
    Console.WriteLine($"Your Total Score Is: {score}/60");

