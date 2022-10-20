class Logic{

    public List<string> WordChecker(List<string> Word, string Letter, List<string> Empty){
        List<string> Placeholder = new List<string>(Empty);
        if (Letter == Word[0]){
            Placeholder[0] = Letter;
            return Placeholder;
        }
        else if(Letter == Word[1]){
            Placeholder[1] = Letter;
            return Placeholder;
        }
        else if(Letter == Word[2]){
            Placeholder[2] = Letter;
            return Placeholder;
        }
        else if(Letter == Word[3]){
            Placeholder[3] = Letter;
            return Placeholder;
        }
        else{
            return Placeholder;
        }
    }
    public int errorcheck(List<string> Empty, List<string> Empty2, int error){
        if (Empty[0] == Empty2[0] && Empty[1] == Empty2[1] && Empty[2] == Empty2[2] && Empty[3] == Empty2[3]){
            error += 1;
            return error;
        }
        else{
            return error;
        }
    }
    public bool GameOver(List<string> ChosenWord, List<string> Empty, int error){
        if (ChosenWord[0] == Empty[0] && ChosenWord[1] == Empty[1] && ChosenWord[2] == Empty[2] && ChosenWord[3] == Empty[3]){
            var GameOver = true;
            return GameOver;
        }
        else if(error > 4){
            var GameOver = true;
            return GameOver;
        }
        else{
            var GameOver = false;
            return GameOver;
        }
    }
}