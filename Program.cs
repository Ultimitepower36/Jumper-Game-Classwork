class jumperManGame{

    static JumpMan JumpMan = new JumpMan();
    static Words Words = new Words();
    static Logic Logic = new Logic();
    List<string> Empty = new List<string>{"_", "_", "_", "_"};
    public static void Main(){
        Console.WriteLine("Welcome to Jumper!");
        Console.WriteLine("Correctly guess the word within 4 guesses to save the Jumper!");
        Console.WriteLine("");
        var GameOver = false;
        List<string> ChosenWord = Words.WordSelection();
        var error = 0;

        while (!GameOver){
            JumpMan.Jumper(0);
            Console.WriteLine("Guess a letter [a-z] (lowercase please): ");
            var letter = Console.ReadLine() ?? "";

            Empty2 = Logic.WordChecker(ChosenWord, letter, Empty, error);

            GameOver = true;
        }
    }
}
