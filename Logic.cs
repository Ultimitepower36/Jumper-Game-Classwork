class Logic{

    public List<string> WordChecker(List<string> Word, string Letter, List<string> Empty, int error){
        if (Letter == Word[0]){
            Empty[0] = Letter;
            return Empty;
        }
        else if(Letter == Word[1]){
            Empty[1] = Letter;
            return Empty;
        }
        else if(Letter == Word[2]){
            Empty[2] = Letter;
            return Empty;
        }
        else if(Letter == Word[3]){
            Empty[3] = Letter;
            return Empty;
        }
        else{
            return Empty;
        }
    }
    public int errorcheck(List<string> Empty1, List<string> Empty2, int error){
        if (Empty1 == Empty2){
            error+=1;
            return error;
        }
        else{
            return error;
        }
    }
    public bool GameOver(List<string> Word, List<string> Empty, int error){
        if (Word == Empty){
            var GameOver = true;
            return GameOver;
        }
        else if(error == 3){
            var GameOver = true;
            return GameOver;
        }
        else{
            var GameOver = false;
            return GameOver;
        }
    }
}