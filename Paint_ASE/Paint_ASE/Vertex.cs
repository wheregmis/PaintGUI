using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Paint_ASE
{
    
   public class Vertex
    {
        private int _x, _y, _z;

        public Vertex(int x, int y, int z) {
            _x = x;
            _y = y;
            _z = z;
        }

        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }
        public int Z { get => _z; set => _z = value; }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}", _x, _y, _z);
        }

        public static bool Parse(String text, out Vertex vertex) {
            const string PATTERN = @"(?<X>\d+), (?<Y>\d+), (?<Z>\d+)";
            Match match = Regex.Match(text, PATTERN);

            if (match.Success)
            {
                int x = int.Parse(match.Groups["X"].Value);
                int y = int.Parse(match.Groups["Y"].Value);
                int z = int.Parse(match.Groups["Z"].Value);

                vertex = new Vertex(x, y, z);
                return true;
            }
            else {
                vertex = new Vertex(0,0,0);
                return false;
            }
        }
    }
}
