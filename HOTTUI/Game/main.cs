using HOTTGF;
using HOTTUI.Game;
using HOTTUI.H.O.T.T.U.I;

internal class Test
{
    public static void Main(string[] args)
    {
        Player player = new Player();
        while (Base.IsGameRunning())
        {
            player.Move();
            player.Draw();
        }
    }
}
