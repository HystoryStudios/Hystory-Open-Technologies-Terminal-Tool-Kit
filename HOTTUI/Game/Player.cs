using HOTTGF;

namespace HOTTUI.Game
{
    public class Player
    {
        public HOTTGF.Object PL = new HOTTGF.Object('i', new System.Numerics.Vector2(10, 10));

        public void Draw()
        {
            PL.Draw(ConsoleColor.White);
        }

        public void Move() 
        {
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.Z:
                    PL.Y -= 1;
                    break;
                case ConsoleKey.Q:
                    PL.X -= 1;
                    break;
                case ConsoleKey.S:
                    PL.Y += 1;
                    break;
                case ConsoleKey.D:
                    PL.X += 1;
                    break;
            }
        }
    }
}
