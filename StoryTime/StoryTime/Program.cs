using System;

namespace StoryTime
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ENGLAND 932AD");

            Console.WriteLine("Hello I'm King Arthur. What's your name?");
            String answer = Console.ReadLine();

            Console.WriteLine(string.Format(@"Hello {0}, welcome.", answer));

            Console.WriteLine("I'm in search for knights who will join me in search of the Holy Grail. Would you like to come along?");
            String answer1 = Console.ReadLine();

            if (answer1 == "yes") 
            {
                Console.WriteLine("Sounds like a deal. Follow me!");
            }

            else
            {
                Console.WriteLine("Aight, peasant.");
            }

            Console.WriteLine("You follow Arthur for what seems like hours, until you reach a fork in the road.");

            Console.WriteLine("On the path to the left, you see a forest . On the path to the right, you see a desert trail.");


            Console.WriteLine("Arthur: Should we take the path on the left or right?");
            String answer2 = Console.ReadLine(); 

            if (answer2 == "right")
            {
                Console.WriteLine("You choose the desert trail, it seems endless");
            }

            else if (answer2 == "left") 
            {
                Console.WriteLine("You choose the forest. You hear twigs crunching under your feet.");
            }

            else
            {
                Console.WriteLine("You wander around aimlessly.");
            }

            Console.WriteLine("After a long journey, you reach the end of the path. A large creature stands in your way.");

            Console.WriteLine("Do you fight, or do you run?");
            String answer3 = Console.ReadLine();

            if (answer3 == "fight") 
            {
                Console.WriteLine("After a short scuffle you manage to kill it, you continue your journey.");
            }

            else if (answer3 == "run") 
            {
                Console.WriteLine("You run away. Well that wasn't very fun or adventurous.");
            }

            else
            {
                Console.WriteLine("I don't quite understand.");
            }

            Console.WriteLine("After the encounter you find a ruffled piece of paper on the floor with a red X on it. Might be helpful!");
            Console.WriteLine("________________________________________________________________________________________________");



            Console.WriteLine("You follow the map for some time and you finally come upon the X. It must be the grail we've been looking for. Shall we dig?");
            String answer4 = Console.ReadLine(); 

            if (answer4 == "yes") 
            {
                Console.WriteLine("You dig and you dig.... and you dig some more");
            }

     
            else
            {
                Console.WriteLine("Arthur: That's coo more treasure for me. ");
                Console.WriteLine("You watch as Arthur digs away.");
            }

            Console.WriteLine("________________________________________________________________________________________________");

            Console.WriteLine("After a few hours of digging you come upon a large chest. Open it?");
            String answer5 = Console.ReadLine(); 

            if (answer5 == "yes") 
            {
                Console.WriteLine("You bash the chest with a bolder endlessly until you hear a crack.");
            } 

            else
            {
                Console.WriteLine("Arthur maniacly bangs the chest with a bolder. You take a step back.");
            }

            Console.WriteLine("Arthur: Well look what we have here!");


            Console.WriteLine("Arthur pulls a large scroll from the chest, beside the scroll the chest is relatively empty.");

            Console.WriteLine("________________________________________________________________________________________________");

            Console.WriteLine("Read the scroll?");
            String answer6 = Console.ReadLine(); 

            if (answer6 == "yes")
            {
                Console.WriteLine("You begin to unravel the scroll.... it reads as follows");


                Console.WriteLine("GREETINGS MORTAL. THIS IS A MESSAGE FROM THE FUTURE. EVERY DECISION YOU JUST MADE WAS PART OF A SIMULATION. THE HOLY GRAIL ISN'T REAL, AND FRANKLY NOTHING IS REAL.");
            }

            else
            {
                Console.WriteLine("Arthur sends you home because of your lack of adventure.");
            }

            Console.WriteLine("THE END.");
















        }
    }
}
