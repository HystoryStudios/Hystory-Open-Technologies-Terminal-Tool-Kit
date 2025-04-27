using HOTTUI.H.O.T.T.U.I;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTTUI
{
    internal class main
    {
        public static void Main(string[] args)
        {

            Dictionary<int, string> map = new Dictionary<int, string>();
            map.Add(1, "jsp");
            map.Add(2, "stp");
            map.Add(3, "tkt");
            Tools.Menu(ConsoleColor.Red, map, "@");

            Window window = new Window(5, 5, '/');

            window.Change(3, 3, '@');

            window.PrintUnicolor(ConsoleColor.White);
        }
    }
}
