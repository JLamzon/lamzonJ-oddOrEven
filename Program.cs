//Jessie Lamzon
//10/18/22
//GitHubChallenge - Redo mini Challenges
//odd or even - data validation and play again 


string playAgain = "yes";

while (playAgain != "no")
{
    
    string userNumber;
    //this int will be used to verify a number
    int validNum = 0;
    // 
    int numBer;
    bool isNumber;

    while (isNumber = true)
    {
        Console.WriteLine("Give number and I will tell you if its odd or even!");

        //this string will be what used to get user input
        userNumber = Console.ReadLine();
        isNumber = Int32.TryParse(userNumber, out validNum);

        //Checks
        if (isNumber == true)
        {
            numBer = Int32.Parse(userNumber);

            if (numBer % 2 == 0)
            {
                Console.WriteLine("You chose a even number");
                break;
            }
            else
            {
                Console.WriteLine("You chose a odd number");
                break;
            }
        }
        else
        {
            Console.WriteLine("You didn't write a number try again!");
        }

    }
    Console.WriteLine("Try again? press any key or type no");
    playAgain = Console.ReadLine();
}
Console.WriteLine("Thanks for playing!");
