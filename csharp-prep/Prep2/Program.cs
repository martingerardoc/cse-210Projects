using System;

class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
        Console.Write("What is your grade percentage? ");
       // string answer = Console.ReadLine();
        int percent = int.Parse(Console.ReadLine());

        string letter = "";

=======
        //input by user
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);
        // program

        string letter = "";
>>>>>>> 5784ff90ac590fb1cedc9540c00fc6ad30c83bff
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}