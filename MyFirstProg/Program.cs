String wordToGuess;
String letterGuess;
String dash;
int hangedManStatus;
bool playAgain = true;
bool gameOver;
char[] dashArray;

while (playAgain)
{
    // Reset
    char guess = ' ';
    hangedManStatus = 0;
    gameOver = false;
    WordToGuess();
    Console.WriteLine("I've chosen a word");

    // Change wordToGuess to Dashes
    dashArray = wordToGuess.ToCharArray();
    for (int i = 0; i < dashArray.Length; i++)
    {
        if (char.IsLetterOrDigit(dashArray[i]))
        {
            dashArray[i] = '-';
        }
    }
    dash = new string(dashArray);
    Console.WriteLine(dash);

    // Game Start
    HangedMan();
    while (dash.Contains("-"))
    {
        // Guess Input
        Console.WriteLine("What is your guess?" +
                          "\nPlease enter a single letter Digit: ");
        while (true)
        {
            letterGuess = Console.ReadLine();
            letterGuess = letterGuess.ToLower();
            guess = ' ';
            if (letterGuess.Length == 1)
            {
                guess = Convert.ToChar(letterGuess);
                if (char.IsLetter(guess))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid option\n Please enter a single digit letter.");
                }
            }
            else
            {
                Console.WriteLine("That is not a valid option\n Please enter a single digit letter.");
            }
        }

        // Compare Guessed Letter
        if (wordToGuess.Contains(letterGuess))
        {
            Console.WriteLine("That letter was correct!");
            char[] dashArrayAns = dash.ToCharArray();
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (wordToGuess[i].ToString() == letterGuess)
                {
                    dashArrayAns[i] = wordToGuess[i];
                }
            }
            dash = new string(dashArrayAns);
            Console.WriteLine(dash);
            HangedMan();
        }
        else
        {
            Console.WriteLine("That letter is not part of the word");
            Console.WriteLine(dash);
            hangedManStatus++;
            HangedMan();
        }
        if (gameOver)
        {
            Console.WriteLine("You've lost!");
            Console.WriteLine("The word was " + wordToGuess);
            break;

        }
        else if (dash.Contains("-") == false)
        {
            Console.WriteLine("You've won!");
            break;
        }
    }

    // Play Again
    while (true)
    {
        Console.WriteLine("Would you like to play again?");
        String play = Console.ReadLine();
        play = play.ToLower();

        if (play == "y")
        {
            playAgain = true;
            break;
        }
        else if (play == "n")
        {
            playAgain = false;
            break;
        }
        else
        {
            Console.WriteLine("That is not a valid Option");
        }
    }
}
void WordToGuess()
{
    List<String> words = new List<String>
    {
        "CPU",
        "Bit",
        "Byte",
        "Binary",
        "RAM",
        "Function",
        "Array",
        "List",
        "Variable",
        "Data",
        "Data Type",
        "ASCII",
        "Linked List",
        "Hash Map",
        "Graph",
        "Algorithm"
    };

    Random random = new Random();
    int randomWord;
    wordToGuess = words[random.Next(0, words.Count)];
    wordToGuess = wordToGuess.ToLower();
}
void HangedMan()
{
    switch (hangedManStatus)
    {
        case 0:
            Console.WriteLine(@"__________
|        |
|        |
|        |
| 
|
|
|
|
|
|
|
|
|
|
|
|
|
| _______________________");
            break;
        case 1:
            Console.WriteLine(@"__________
|        |
|        |
|      __|__
|     /     \
|     |     |
|     \_____/
|   
|     
|  
|    
|
|  
|   
|   
|   
|
|
| _______________________");
            break;
        case 2:
            Console.WriteLine(@"__________
|        |
|        |
|      __|__
|     /     \
|     |     |
|     \_____/
|        |
|        |
|        | 
|        |  
|        |   
|        
|    
|    
|   
|
|
| _______________________");
            break;
        case 3:
            Console.WriteLine(@"__________
|        |
|        |
|      __|__
|     /     \
|     |     |
|     \_____/
|        |
|       /|
|      / |
|     /  |
|    /   |
|   
|   
|   
|  
|
|
| _______________________");
            break;
        case 4:
            Console.WriteLine(@"__________
|        |
|        |
|      __|__
|     /     \
|     |     |
|     \_____/
|        |
|       /|\
|      / | \
|     /  |  \
|    /   |   \
| 
|    
|  
| 
|
|
| _______________________");
            break;
        case 5:
            Console.WriteLine(@"__________
|        |
|        |
|      __|__
|     /     \
|     |     |
|     \_____/
|        |
|       /|\
|      / | \
|     /  |  \
|    /   |   \
|       / 
|      /  
|     /     
|    /       
|
|
| _______________________");
            break;
        case 6:
            Console.WriteLine(@"__________
|        |
|        |
|      __|__
|     /     \
|     |     |
|     \_____/
|        |
|       /|\
|      / | \
|     /  |  \
|    /   |   \
|       / \
|      /   \
|     /     \
|    /       \
|
|
| _______________________");
            gameOver = true;
            break;
    }
}