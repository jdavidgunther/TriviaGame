using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Trivia
{
    class Game
    {
        string gameName = "Trivia Game by Jack";

        public void Execute()
        {
            //Game Intro

            Title = gameName;
            WriteLine("Welcome to " + gameName);
            WriteLine("Instructions: Type your answer and hit enter to continue.");
            WriteLine("What is your name?");
            string input = ReadLine();
            WriteLine("Hello " + input + " Press enter to start");
            ReadKey();
            Clear();

            //Question 1

            TriviaItem classOverview = new TriviaItem();
            classOverview.QuestionText = "What element types can you choose from when starting pokemon?";
            classOverview.Answer = "Fire, Water, and Grass";

            WriteLine(classOverview.Show());
            input = ReadLine();
            WriteLine("You answered " + input + " and the correct answer was " + classOverview.Answer);
            WriteLine("Press enter to continue");
            ReadKey();
            Clear();

            //Question 2

            classOverview.QuestionText = "How many pokemon generations are there currently?";
            classOverview.Answer = "7";

            WriteLine(classOverview.Show());
            input = ReadLine();
            WriteLine("You answered " + input + "the correct answer was " + classOverview.Answer);
            WriteLine("Press enter to continue");
            ReadKey();
            Clear();

            //Question 3

            classOverview.QuestionText = "What type of attack has no effect against ground type pokemon?";
            classOverview.Answer = "Electric";

            WriteLine(classOverview.Show());
            input = ReadLine();
            WriteLine("You answered " + input + " the correct answer was " + classOverview.Answer);
            WriteLine("Press enter to continue");
            ReadKey();
            Clear();

            //End of Game

            WriteLine("Thanks for playing");
            WriteLine("Press enter to exit");
            ReadKey();




        }
    }
}
