using HOTTGF;
using HOTTUI.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HOTTGF
{
    public class Object
    {
        public char Texture {  get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Object(char texture, Vector2 position)
        {
            Texture = texture;
            X = (int) position.X;
            Y = (int) position.Y;
        }

        public void Draw(ConsoleColor color)
        {
            Console.Clear();
            Console.SetCursorPosition(X, Y);
            Tools.Color_Write(color, Texture.ToString());

            // clear 

            
        }
    }
}
