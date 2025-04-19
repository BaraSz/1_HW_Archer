namespace _1_lucistnik;

class Program
{
    public static int ReturnTheIntiger (string numberOfAddedArrowsText)
    {
        int numerOfAddedArrows;
        bool isAnumber = int.TryParse(numberOfAddedArrowsText, out numerOfAddedArrows);

        while (isAnumber == false || numerOfAddedArrows <= 0)
        {
            Console.WriteLine("Enter a whole number greater than 0.");
            numberOfAddedArrowsText = Console.ReadLine();
            isAnumber = int.TryParse(numberOfAddedArrowsText, out numerOfAddedArrows);
        }

        return numerOfAddedArrows;
    }
    static void Main(string[] args)
    {
        Archer David = new Archer("David", 5);
        David.ShowInfo();

        bool RepeatTheCycle = true;
        while (RepeatTheCycle)
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
                    David.AddArrows(ReturnTheIntiger(Console.ReadLine()));
                    break;

                case "3":
                    Console.WriteLine("End of the program");
                    RepeatTheCycle = false;
                    break;

                default:
                    Console.WriteLine("Press 1, 2, or 3 for the next step.");
                    break;

            }
        }
    }
}
