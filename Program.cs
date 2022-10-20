class jumperManGame{

    static JumpMan JumpMan = new JumpMan();
    static Words Words = new Words();

    public static void Main(){
        Console.WriteLine("Welcome to Jumper!");
        Console.WriteLine("Correctly guess the word within 4 guesses to save the Jumper!");
        Console.WriteLine("");
        var GameOver = false;
        var ChosenWord = Words.WordSelection();

        while (!GameOver){
            JumpMan.Jumper(0);
            Console.WriteLine("Guess a letter [a-z] (lowercase please): ");
            var letter = Console.ReadLine() ?? "";

            GameOver = true;
        }
    }
}
