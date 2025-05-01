using HOTTUI;
using HOTTUI.Menu;
using HOTTUI.H.O.T.T.U.I;

namespace HOTTGF
{
    public class Base
    {
        public static bool IsGameRunning()
        {
            bool isRunning = true;

            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                isRunning = false;
            }

            return isRunning;
        }
    }
}
