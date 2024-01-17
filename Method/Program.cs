namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Setting initial values for name and age
            String name = "Apothecary";
            int age = 28;

            // Calling the method to sing happy birthday
            singHappyBirthday(name, age);

            // Waiting for user input before exiting
            Console.ReadKey();
        }

        // Method to sing happy birthday with provided name and age
        static void singHappyBirthday(String name, int age)
        {
            // Printing birthday song lines with personalized message
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine("Happy Birthday dear " + name);
            Console.WriteLine("You are " + age + " years old");
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine();
        }
    }
}
