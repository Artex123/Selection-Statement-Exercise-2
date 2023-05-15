namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            
            string subject = Console.ReadLine();
            
            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is awesome!");
                    break;
                case "gym":
                    Console.WriteLine("Gym is fun!");
                    break;
                case "history":
                    Console.WriteLine("I love History.");
                    break;
                case "science":
                    Console.WriteLine("Science is the best!");
                    break;
                case "english":
                    Console.WriteLine("English can get really boring.");
                    break;
                default:
                    Console.WriteLine("That is not a subject that I recognize!");
                    break;
            }
        }
    }
}