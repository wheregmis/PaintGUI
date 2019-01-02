using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_ASE
{
   public class ParseSyntax
    {

        public Boolean TestSyntax(String syntax) {

            if (syntax.Equals("Draw Rectangle"))
            {
                return true;
            }
            else {

                return false;
            }

           
        }
    }
}
