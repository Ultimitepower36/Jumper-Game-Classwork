public class logic
{
    private static int printWord(List<char>guesses, String randomWord)
    {
        int counter = 0;	
        int correctLetters = 0;
        Console.Write("\r\n")
        foreach(char x in randomWord)
        {
            if(guesses.Contains(x))
            Console.Write(x + " ");
            correctLetters++;
        }
        else {
            Console.Write(" ");
        }
        counter++;
    }
    return correctLetters
