using HOTTUI;
using HOTTUI.Menu;

namespace HOTTGF
{
    public class TileMap
    {
        public char[,] chars;
        public Window window { get; set; }
        public TileMap(char[,] tilemap) 
        {
            chars = tilemap;
        }
        public void DrawUniColor(ConsoleColor color)
        {
            for (int y = 0; y < chars.GetLength(0); y++)
            {
                for (int x = 0; x < chars.GetLength(1); x++)
                {
                    Console.SetCursorPosition(x, y);
                    Tools.Color_Write(color, chars[y, x].ToString());
                }
            }
        }
    }
}
