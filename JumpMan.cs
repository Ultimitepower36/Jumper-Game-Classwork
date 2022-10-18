public class JumpMan
{
    string Row1 = "    ______    ";
    string Row2 = @"   /______\   ";
    string Row3 = @"    \   /    ";
    string Row4 = @"     \ /     ";
    string Row5 = "      O ";
    string Row6 = @"     /|\ ";
    string Row7 = @"     / \ ";
    string Row8 = "^^^^^^^^^^^^^^";

    public void Jumper(int error)
    {
        if (error == 0) {
            Console.WriteLine($"Row1");
        }
        if (error <= 1) {
            Console.WriteLine($"Row2");
        }
        if (error <= 2) {
            Console.WriteLine($"Row3");
        }
        if (error <= 2) {
            Console.WriteLine($"Row4");
        }
        Console.WriteLine($"Row5");
        Console.WriteLine($"Row6");
        Console.WriteLine($"Row7");
        Console.WriteLine($"Row8");
        return;
    }
}