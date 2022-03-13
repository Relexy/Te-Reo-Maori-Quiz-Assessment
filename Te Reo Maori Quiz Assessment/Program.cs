
int score = 0;
bool validGuess = false;
bool gameFinish = false;
int quizNum = 0;

// Member, Article, Achieve, Conclusion, Bottom, Ally, Spray, Carry, Jail, Shoot, Galaxy, Compact, Highway, Sacred, Tool
string[] words = new string[] { "mema", "atikara", "tutuki", "mutunga", "whakatakere", "haumi", "wairehu", "pakihere", "whare herehere", "pipihi", "ikarangi", "kiato", "huanui", "puaroa", "keteparaha" };
string[] answers = new string[] { "Member", "Article", "Achieve", "Conclusion", "Bottom", "Ally", "Spray", "Carry", "Jail", "Shoot", "Galaxy", "Compact", "Highway", "Sacred", "Tool" };
string[] optionsQ1 = new string[] { "dilemma", "memory", "remember"};
string[] optionsQ2 = new string[] { "attic", "attend", "athletic" };
string[] optionsQ3 = new string[] { "agile", "trolley", "trust" };
string[] optionsQ4 = new string[] { "measure", "mountain", "mechanic" };
string[] optionsQ5 = new string[] { "withdraw", "waiter", "builder" };
string[] optionsQ6 = new string[] { "heat", "helmet", "helping" };
string[] optionsQ7 = new string[] { "wrestle", "wardrobe", "wine" };
string[] optionsQ8 = new string[] { "positivity", "contain", "clapping" };
string[] optionsQ9 = new string[] { "mansion", "construction", "mall" };
string[] optionsQ10 = new string[] { "peeking", "produce", "liar" };
string[] optionsQ11 = new string[] { "inclusive", "irony", "feast" };
string[] optionsQ12 = new string[] { "know", "kidney", "prestige" };
string[] optionsQ13 = new string[] { "headquarters", "hardship", "harbor" };
string[] optionsQ14 = new string[] { "sacrifice", "smash", "portal" };
string[] optionsQ15 = new string[] { "container", "kitchen", "position" };

for (int i = 0; i < optionsQ1.Length; i++)
{
    optionsQ1[i].ToLower();
}
for (int i = 0; i < answers.Length; i++)
{
    answers[i] = answers[i].ToLower();
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
    Console.WriteLine($"Your 1st Word Is... {words[quizNum]}");
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
                Console.WriteLine($"Your 2nd Word Is... {words[quizNum]}");
                Console.WriteLine($"A. {optionsQ2[0]} \nB. {answers[1]} \nC. {optionsQ2[1]} \nD. {optionsQ2[2]} \n(Remember To Type The Word)");
                    break;

                case 2:
                Console.WriteLine($"Your 3rd Word Is... {words[quizNum]}");
                Console.WriteLine($"A. {optionsQ3[0]} \nB. {answers[2]} \nC. {optionsQ3[1]} \nD. {optionsQ3[2]} \n(Remember To Type The Word)");
                    break;

                case 3:
                    Console.WriteLine($"Your 4th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {optionsQ4[0]} \nB. {answers[3]} \nC. {optionsQ4[1]} \nD. {optionsQ4[2]} \n(Remember To Type The Word)");
                    break;

                case 4:
                    Console.WriteLine($"Your 5th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {optionsQ5[0]} \nB. {optionsQ5[1]} \nC. {optionsQ5[2]} \nD. {answers[4]} \n(Remember To Type The Word)");
                    break;

                case 5:
                    Console.WriteLine($"Your 6th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {optionsQ6[0]} \nB. {answers[5]} \nC. {optionsQ6[1]} \nD. {optionsQ6[2]} \n(Remember To Type The Word)");
                    break;

                case 6:
                    Console.WriteLine($"Your 7th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {answers[6]} \nB. {optionsQ7[0]} \nC. {optionsQ7[1]} \nD. {optionsQ7[2]} \n(Remember To Type The Word)");
                    break;

                case 7:
                    Console.WriteLine($"Your 8th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {optionsQ8[0]} \nB. {answers[7]} \nC. {optionsQ8[1]} \nD. {optionsQ8[2]} \n(Remember To Type The Word)");
                    break;

                case 8:
                    Console.WriteLine($"Your 9th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {optionsQ9[0]} \nB. {optionsQ9[1]} \nC. {optionsQ9[2]} \nD. {answers[8]} \n(Remember To Type The Word)");
                    break;

                case 9:
                    Console.WriteLine($"Your 10th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {answers[9]} \nB. {optionsQ10[0]} \nC. {optionsQ10[1]} \nD. {optionsQ10[2]} \n(Remember To Type The Word)");
                    break;

                case 10:
                    Console.WriteLine($"Your 11th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {optionsQ11[0]} \nB. {answers[10]} \nC. {optionsQ11[1]} \nD. {optionsQ11[2]} \n(Remember To Type The Word)");
                    break;

                case 11:
                    Console.WriteLine($"Your 12th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {optionsQ12[0]} \nB. {optionsQ12[1]} \nC. {answers[11]} \nD. {optionsQ12[2]} \n(Remember To Type The Word)");
                    break;

                case 12:
                    Console.WriteLine($"Your 13th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {answers[12]} \nB. {optionsQ13[0]} \nC. {optionsQ13[1]} \nD. {optionsQ13[2]} \n(Remember To Type The Word)");
                    break;

                case 13:
                    Console.WriteLine($"Your 14th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {optionsQ14[0]} \nB. {optionsQ14[1]} \nC. {optionsQ14[2]} \nD. {answers[13]} \n(Remember To Type The Word)");
                    break;

                case 14:
                    Console.WriteLine($"Your 15th Word Is... {words[quizNum]}");
                    Console.WriteLine($"A. {optionsQ15[0]} \nB. {answers[14]} \nC. {optionsQ15[1]} \nD. {optionsQ15[2]} \n(Remember To Type The Word)");
                    break;
            }
        }
        validGuess = false;
    }

    Console.WriteLine($"Your Total Score Is: {score}/30");
}