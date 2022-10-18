class Words{

    List<string> Word = new List<string>{"W", "O", "R", "D"};
    List<string> Mark = new List<string>{"M", "A", "R", "K"};
    List<string> Fill = new List<string>{"F", "I", "L", "L"};
    List<string> Star = new List<string>{"S", "T", "A", "R"};
    List<string> Done = new List<string>{"D", "O", "N", "E"};
    List<string> Options = new List<string>{"Word", "Mark", "Fill", "Star", "Done"};

    public WordSelection(){
        Random rnd = new Random();
        int number = rnd. Next(0, 5);
        var Selected = Options[number];
        List<string> Chosen = new List<string>{};
        if (Selected == "Word"){
            Chosen = Word;
        }
        if (Selected == "Mark"){
            Chosen = Mark;
        }
        if (Selected == "Fill"){
            Chosen = Fill;
        }
        if (Selected == "Star"){
            Chosen = Star;
        }
        if (Selected == "Done"){
            Chosen = Done;
        }

        return Chosen;
    }
}