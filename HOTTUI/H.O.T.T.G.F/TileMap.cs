using HOTTUI;
using HOTTUI.Menu;
using HOTTUI.H.O.T.T.U.I;

namespace HOTTGF
{
    public class TileMap
    {
        public char[,] chars;
        public Window Window { get; set; }
        public TileMap(int SizeX, int SizeY, char Background) 
        {
            Window = new Window(SizeY, SizeX, Background);
            Window.CreateBackGround();
        }

        public void DrawUniColor(ConsoleColor color)
        {
            Window.PrintUnicolor(color);
        }
    }
}
