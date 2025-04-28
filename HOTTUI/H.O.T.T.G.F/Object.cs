using HOTTGF;
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
        public Vector2 Position { get; set; }
        public Object(char texture, Vector2 position)
        {
            Texture = texture;
            Position = position;
        }
    }
}
