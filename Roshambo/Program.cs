//Namespaces organise your code and prevent naming conflicts with other libaries 
namespace Roshambo;

//This brings in core system functionality 
using System;

public class Program
{
    //the main class 
    static void Main(string[] args)
    {
        var user = args.Length > 0 ? args[0] : "Rock";

        var computer = args.Length > 0 ? args[0] : "Rock";

        Console.WriteLine(DecideWinner(user, computer));
    }

    public static string DecideWinner(string user, string computer)
    {
        //rule 1
        if (user == computer) return "Draw";

        //rule 2
        if ((user == "Rock" && computer == "Scissors") ||  (user == "Paper" && computer == "Rock") || (user == "Scissors" && computer == "Paper"))
                {
                    return "Win";
                }
        //rule3
        return "Lose";
    }
}
