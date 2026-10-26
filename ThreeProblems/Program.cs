
using System.Numerics;

int choice = 0;

Random rng = new Random(4000);

const int passing = 60;
const int numberOfScores = 5;
const int guiOptions = 5;

do
{
    

    System.Console.WriteLine(" === CSCI 1250 Lab 06 === ");
System.Console.WriteLine("1. The Grade Checker ");
System.Console.WriteLine("2. The Dice Table ");
System.Console.WriteLine("3. The Score Report ");
System.Console.WriteLine("4. All three ");
System.Console.WriteLine("5. Quit   "  );
Console.Write("Choose 1 through 5:");

int.TryParse(Console.ReadLine(), out choice);
//a while loop that calculates the number grade the user gives into a letter 
if (choice == 1 || choice == 4)

{
    System.Console.WriteLine("    ");
    System.Console.WriteLine(" === Exercise 1: The Grade Checker === ");
    Console.Write("Score: ");
    int score = int.Parse(Console.ReadLine());
    while (score < 0 || score > 100)
    {
        System.Console.WriteLine("A score must be between 0 and 100.");
        Console.Write("Score: ");
        score = int.Parse(Console.ReadLine());

    }

    if (score >= 90)
    {
        System.Console.WriteLine(score + " earns a A");
    }
    else if (score >= 80)
    {
        System.Console.WriteLine(score + " earns a B");
    }
    else if (score >= 70)
    {
        System.Console.WriteLine(score + " earns a C");
    }
    else if (score >= 60)
    {
        System.Console.WriteLine(score + " earns a D");
    }
    else
    {
        System.Console.WriteLine(score + " earns a F " );
    }

}
//do while loop that rolls a set a dice first then asks the user if they want to roll again 
// also  determines if you get doubles, snake eyes, or a win.
if(choice == 2 || choice == 4)
    {
        System.Console.WriteLine(" === Exercise 2: The Dice Table === ");
        int timesRolled = 0;
        int timesWon = 0;
        string rollAgain;
        do
        {
            timesRolled++;
            int die1 = rng.Next(1, 7);
            int die2 = rng.Next(1, 7);
            int total = die1 + die2;
            System.Console.WriteLine("Roll " + timesRolled + ": " + die1 + " and " + die2 + ", total " + total + ".");

            if(die1 == 1 && die2 == 1)
            {
                System.Console.Write(" Snake eyes. " );
            }
            else if (die1 == die2)
            {
                System.Console.Write(" Doubles! " );
            }
    if(total == 7 || total == 11)
            {
                timesWon++;
                System.Console.Write("A winner. " );
            }

            System.Console.WriteLine("Roll again? (y/n): ");
            rollAgain = Console.ReadLine().ToLower();

        }while (rollAgain == "y");

        System.Console.WriteLine("You rolled " + timesRolled + "times and won " + timesWon + "."  );
    }

//A for loop that fills each position in the array and labels the score
if(choice == 3 || choice == 4)
    {
        System.Console.WriteLine("=== Exercise 3: The Score Report === ");
        int[] scores = new int[numberOfScores];
        for(int i = 0; i < scores.Length; i++)
        {
            System.Console.WriteLine("Score " + (i + 1) + ": ");
            scores[i] = int.Parse(Console.ReadLine());
        }
        
        int highestScore = scores[0];
        int countPassing = 0;
        int total = 0;
        foreach(int score in scores)
        {
            total += score;
        
            if(score > highestScore)
            {
                highestScore = score;
            }
            
            if(score >= countPassing)
            {
                countPassing++;
            } 
        }
    
    double average = 0;
    average = (double)total / scores.Length;
   
   System.Console.WriteLine("Total: " + total);
   System.Console.WriteLine("Average: " + average);
   System.Console.WriteLine("Highest: " + highestScore);
   System.Console.WriteLine("Passing Scores " + countPassing + " of " + scores.Length);
    }


}while (choice != 5);

Console.WriteLine("Goodbye.");

    