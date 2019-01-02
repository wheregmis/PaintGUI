using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Paint_ASE
{
    public class ParseRectangle
    {
        private int _x, _y;

        public ParseRectangle(int x, int y) {
            this._x = x;
            this._y = y;

        }

        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }

        public static bool Parse(String text)
        {
            const string PATTERN = @"(?<X>\d), (?<Y>\d)";
            Match match = Regex.Match(text, PATTERN);

            if (match.Success)
            {
                int x = int.Parse(match.Groups["X"].Value);
                int y = int.Parse(match.Groups["Y"].Value);
                

               
                return true;
            }
            else
            {
               
                return false;
            }
        }
    }
}
