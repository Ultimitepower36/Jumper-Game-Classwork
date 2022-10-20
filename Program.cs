class jumperManGame{

    JumpMan JumpMan = new JumpMan();
    Words Words = new Words();

    public void Game(){
        Console.WriteLine("Welcome to Jumper!");
        Console.WriteLine("Correctly guess the word within 4 guesses to save the Jumper!");
        Console.WriteLine("");
        var GameOver = false;
        var ChosenWord = Words.WordSelection();

        while (!GameOver){
            JumpMan.Jumper(0);
            Console.WriteLine("Guess a letter [a-z] (lowercase please): ");

        }
    }
}
