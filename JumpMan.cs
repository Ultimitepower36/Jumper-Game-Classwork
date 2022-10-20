public class JumpMan
{
    string Row1 = "    _____    ";
    string Row2 = @"   /_____\   ";
    string Row3 = @"    \   /    ";
    string Row4 = @"     \ /     ";
    string Row5 = "      O ";
    string RowGameOver = "      X ";
    string Row6 = @"     /|\ ";
    string Row7 = @"     / \ ";
    string Row8 = "^^^^^^^^^^^^^^";

    public void Jumper(int error)
    {
        if (error == 0) {
            Console.WriteLine($"{Row1}");
            Console.WriteLine($"{Row2}");
            Console.WriteLine($"{Row3}");
            Console.WriteLine($"{Row4}");
        }
        if (error < 1) {
             Console.WriteLine($"{Row3}");
             Console.WriteLine($"{Row4}");
        }
        if (error < 2) {
            Console.WriteLine($"{Row4}");
        }
        if (error == 4){
            Console.WriteLine($"{RowGameOver}");
        }
        else {
            Console.WriteLine($"{Row5}");
        }
        Console.WriteLine($"{Row6}");
        Console.WriteLine($"{Row7}");
        Console.WriteLine($"{Row8}");
        return;
    }
}