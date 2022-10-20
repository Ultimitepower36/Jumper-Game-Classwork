class Words{

    List<string> Word = new List<string>{"W", "O", "R", "D"};
    List<string> Mark = new List<string>{"M", "A", "R", "K"};
    List<string> Shot = new List<string>{"S", "H", "O", "T"};
    List<string> Star = new List<string>{"S", "T", "A", "R"};
    List<string> Done = new List<string>{"D", "O", "N", "E"};
    List<string> Options = new List<string>{"Word", "Mark", "Shot", "Star", "Done"};

    public List<string> WordSelection(){
        Random rnd = new Random();
        int number = rnd. Next(0, 5);
        var Selected = Options[number];
        List<string> Chosen = new List<string>{};
        if (Selected == "Word"){
            Chosen = Word;
        }
        else if (Selected == "Mark"){
            Chosen = Mark;
        }
        else if (Selected == "Shot"){
            Chosen = Shot;
        }
        else if (Selected == "Star"){
            Chosen = Star;
        }
        else if (Selected == "Done"){
            Chosen = Done;
        }
        else{
            Chosen = Word;
        }

        return Chosen;
    }
}