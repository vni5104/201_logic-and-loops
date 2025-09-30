namespace LogicAndLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerName = "adventurer";
            string userChoice = "NONE";

            Console.Write("Welcome to the jungle.\n" + "We got fun and games.\n" +
                "We got everything you want.\n" + "Honey, we know the names.\n\n");
            Console.WriteLine("Wait...I don't actually know your name.");
            Console.WriteLine("What is your name?");
            Console.WriteLine("[Please enter your name, then press 'ENTER' on the keyboard]");

            //Get user input
            playerName = Console.ReadLine();
            Console.WriteLine("\nWelcome to the jungle, " + playerName + "!");

            //Continue the story
            Console.WriteLine("We approach a clearing in the jungle.\n" +
                "There seems to be a trail to the left...\n" + "And a cave entrance to the right.\n");
            Console.WriteLine("Which path do you choose?");
            Console.WriteLine("Type 'left' to choose the path and go left or type 'right' to choose " +
                "the cave and go right.");
            userChoice = Console.ReadLine();
            Console.WriteLine("\nYou chose: " + userChoice + "\n");

            if (userChoice == "left")
            {
                //Go left
                Console.WriteLine("You take the path on the left. It leads you out of the jungle. You " +
                    "are safe to go on another adventure.");
            }
            else if (userChoice == "right")
            {
                //Go right
                Console.Write("You take the path on the right. It leads you into a cave. There is a cave " +
                    "in and you are trapped!");
            } else
            {
                //User typed in something else
                userChoice = "NONE";
                while (userChoice != "left" && userChoice != "right" && userChoice != "under")
                {
                    Console.WriteLine("Please enter 'left', 'right', or the secret option *****");
                    userChoice = Console.ReadLine();
                    Console.WriteLine("\nYou chose: " + userChoice + "\n");

                    if (userChoice == "left")
                    {
                        //Go left
                        Console.WriteLine("You take the path on the left. It leads you out of the jungle. You " +
                            "are safe to go on another adventure.");
                    } else if (userChoice == "right")
                    {
                        //Go right
                        Console.Write("You take the path on the right. It leads you into a cave. There is a cave " +
                            "in and you are trapped!");
                    }
                    else if (userChoice == "under")
                    {
                        //Go under (easter egg)
                        Console.WriteLine("Is there something crawling in your direction?!");
                        Console.WriteLine("...");
                    }
                    else
                    {
                        Console.WriteLine("You're getting off-script.");
                    }
                }
            }
        }
    }
}
