using HOTTGF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Layermap
    {
        private Dictionary<int, TileMap> Maps;
        public char UPC {  get; set; }
        public char DOWNC {  get; set; }
        public Layermap(Dictionary<int, TileMap> maps, char dOWNC, char uPC)
        {
            Maps = maps;
            DOWNC = dOWNC;
            UPC = uPC;
        }

        public void Update()
        {

        }
    }
}
