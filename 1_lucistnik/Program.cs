namespace _1_lucistnik;

class Program
{
    public static int ReadIntegerFromConsole()
    {
        int numberOfAddedArrows = 0;
        bool isANumber = false;

        while (isANumber == false || numberOfAddedArrows <= 0)
        {
            Console.WriteLine("Enter a whole number greater than 0.");
            string numberOfAddedArrowsText = Console.ReadLine();
            isANumber = int.TryParse(numberOfAddedArrowsText, out numberOfAddedArrows);
        }

        return numberOfAddedArrows;
    }
    static void Main(string[] args)
    {
        Archer David = new Archer("David", 5);
        David.ShowInfo();

        while (true)
        {
            Console.WriteLine("Choose your next step:");
            Console.WriteLine("[1] Fire a bow shot");
            Console.WriteLine("[2] Add arrows");
            Console.WriteLine("[3] Exit");

            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    David.BowShot();
                    break;

                case "2":
                    Console.WriteLine("How many arrows do you want to add?");
                    //string numberOfArrowsToAddText = Console.ReadLine();
                    //int numberOfArrowsToAdd = ReturnTheIntiger(Console.ReadLine());
                    David.AddArrows(ReadIntegerFromConsole());
                    break;

                case "3":
                    Console.WriteLine("End of the program");
                    return;

                default:
                    Console.WriteLine("Press 1, 2, or 3 for the next step.");
                    break;

            }
        }
    }
}
