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
        }
    }
}
