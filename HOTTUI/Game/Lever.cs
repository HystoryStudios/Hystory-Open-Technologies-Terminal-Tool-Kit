using HOTTGF;
using System.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game;

namespace Game
{
    public class Lever : GameObject
    {
        public Vector2 Position { get; set; }
        public Lever(Vector2 position) 
            : base ('/', position)
        {
            Position = position;
        }

        public bool IsPressed(Player player)
        {
            Vector2 pp = new Vector2(player.X, player.Y);
            if (Position == pp)
            {
                Texture = '|';
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
