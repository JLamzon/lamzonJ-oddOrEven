//Jessie Lamzon
//10/18/22
//GitHubChallenge - Redo mini Challenges
//odd or even - data validation and play again 
// Peer Review: Pedro Castaneda - Jessie's program ran without any bugs. 
// His validation is on point. I liked how you can replay the game hitting any key.

Console.Clear();
string playAgain = "yes";

while (playAgain != "no")
{
    string userNumber;
    bool isNumber;

    while (true)
    {
        //using long variable for user input
        long validNum = long.MaxValue;

        Console.WriteLine("Give number and I will tell you if its odd or even!");

        //this string will be what used to get user input
        userNumber = Console.ReadLine();

        //checking if user input are numbers but parsing data
        isNumber = Int64.TryParse(userNumber, out validNum);

        if (isNumber == false)
        {
            Console.WriteLine("Too long or wrong input...\nTry again...\n");
        }
        else if (validNum % 2 == 0)
        {
            Console.WriteLine("You chose a even number\n");
            break;
        }
        else if (validNum % 2 == 1)
        {
            Console.WriteLine("You chose a odd number\n");
            break;
        }
    }
    Console.WriteLine("Try again? press any key or type no...");
    playAgain = Console.ReadLine().ToLower();
}
Console.WriteLine("Thanks for playing!");
