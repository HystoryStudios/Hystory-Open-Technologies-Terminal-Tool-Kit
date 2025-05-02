using HOTTGF;

namespace Game
{
    public class Player : GameObject
    {
        public Player (int x, int y)
            :base('i', new System.Numerics.Vector2(10, 10)) 
        {
            X = x;
            Y = y;
        }

        public void Update(char[,] map, List<char> colision)
        {
            var key = Console.ReadKey(true).Key;
            int newX = X;
            int newY = Y;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    newY -= 1;
                    break;
                case ConsoleKey.DownArrow:
                    newY += 1;
                    break;
                case ConsoleKey.LeftArrow:
                    newX -= 1;
                    break;
                case ConsoleKey.RightArrow:
                    newX += 1;
                    break;
            }


            if (!colision.Contains(map[newY, newX]))
            {
                X = newX;
                Y = newY;
            }
        }
    }
}
