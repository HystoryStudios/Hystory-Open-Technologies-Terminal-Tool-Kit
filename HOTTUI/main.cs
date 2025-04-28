using HOTTGF;
using HOTTUI.H.O.T.T.U.I;

internal class Test
{
    public static void Main(string[] args)
    {
        Console.CursorVisible = false;
        Dictionary<int, string> map = new Dictionary<int, string>();
        map.Add(1, "test HOTTUI");
        map.Add(2, "test HOTTGF");
        int respond = HOTTUI.Menu.Tools.Menu(ConsoleColor.Red, map, "@");

        switch(respond)
        {
            case 1:
                Window window = new Window(10, 10, '.');
                Random random = new Random();
                for (int i = 0; i < 1000; i++)
                {
                    //window.CreateBackGround();
                    window.Change(random.Next(10), random.Next(10), '@');

                    window.PrintUnicolor(ConsoleColor.White);
                    Thread.Sleep(100);
                    Console.Clear();
                }
                break;
            case 2:
                TileMap tileMap = new TileMap(10, 10, ' ');
                HOTTGF.Object player = new HOTTGF.Object('i', new System.Numerics.Vector2(5,5));
                tileMap.DrawUniColor(ConsoleColor.White);
                break;
        }
    }
}
