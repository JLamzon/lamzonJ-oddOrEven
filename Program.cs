//Jessie Lamzon
//10/18/22
//GitHubChallenge - Redo mini Challenges
//odd or even - data validation and play again 

Console.Clear();
string playAgain = "yes";

while (playAgain != "no")
{
    string userNumber;
    bool isNumber;

    while (true)
    {
        
        long validNum = long.MaxValue;

        Console.WriteLine("Give number and I will tell you if its odd or even!");
        //this string will be what used to get user input
        userNumber = Console.ReadLine();
        isNumber = Int64.TryParse(userNumber, out validNum);

        if (isNumber == false)
        {
            Console.WriteLine("Try again...");
        }
        else if (validNum % 2 == 0)
        {
            Console.WriteLine("You chose a even number");
            break;
        }
        else if (validNum % 2 == 1)
        {
            Console.WriteLine("You chose a odd number");
            break;
        }
    }
    Console.WriteLine("Try again? press any key or type no");
    playAgain = Console.ReadLine().ToLower();
}
Console.WriteLine("Thanks for playing!");
