namespace Assignment3._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = GetString();
            CountBlankSpaces(sentence);
        }

        public static string GetString()
        {
            string userInput = "test";
            do
            {
                Console.WriteLine("Please enter a sentence and the program will tell you how many blank spaces it contains.");
                userInput = Console.ReadLine();
            } while (userInput == "");

            return userInput;
        }

        public static void CountBlankSpaces(string sentence)
        {
            int counter = 0;
            foreach (char c in sentence)
            {
                if (c == ' ') counter++;
            }
            Console.WriteLine($"\"{sentence}\" contains {counter} blank spaces");
        }
    }
}
