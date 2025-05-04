using Game;
using HOTTGF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HOTTUI.Game
{
    public class Teleporteur : GameObject
    {
        public Vector2 Position { get; set; }
        public Vector2 Position2 { get; set; }
        public Teleporteur(Vector2 positionO, Vector2 position2)
                :base ('!', positionO)
        {
            Position = positionO;
            Position2 = position2;
        }

        public void Teleport(Player player)
        {
            Vector2 pp = new Vector2(player.X, player.Y);
            if (Position == pp)
            {
                player.X = (int) Position2.X;
                player.Y = (int) Position2.Y;
            }
        }
    }
}
