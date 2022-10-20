class jumperManGame{

    static JumpMan JumpMan = new JumpMan();
    static Words Words = new Words();
    static Logic Logic = new Logic();
    public static void Main(){
        Console.WriteLine("Welcome to Jumper!");
        Console.WriteLine("Correctly guess the word within 4 guesses to save the Jumper!");
        Console.WriteLine("");
        var GameOver = false;
        List<string> Empty = new List<string>{"_", "_", "_", "_"};
        List<string> ChosenWord = Words.WordSelection();
        var error = 0;
        var error2 = 0;
        var x = 5;

        while (!GameOver){
            Console.WriteLine($"{Empty[0]}{Empty[1]}{Empty[2]}{Empty[3]}");
            JumpMan.Jumper(error);
            Console.WriteLine($"You have {x} live(s) left.");
            Console.WriteLine("Guess a letter [A-Z] (Uppercase please): ");
            var letter = Console.ReadLine() ?? "";

            List<string> Empty2 = Logic.WordChecker(ChosenWord, letter, Empty);

            error2 = Logic.errorcheck(Empty, Empty2, error);

            if (error2 != error){
                error = error2;
                x = x - 1;
            }
            else{
                Empty = Empty2;
            }

            GameOver = Logic.GameOver(ChosenWord, Empty, error);
            if (error>4){
                JumpMan.Jumper(error);
                Console.WriteLine("You died, feel free to try again.");
            }
            else if(GameOver == true){
                Console.WriteLine("You won! Thanks for playing.");
            }
        }
    }
}
