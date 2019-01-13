using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE_Paint.com.paint.exception
{
    /// <summary>
    /// path exception handling class
    /// </summary>
    public class PathException : Exception
    {
        /// <summary>
        /// Exception handling for empty path
        /// </summary>
        /// <param name="message"></param>
        public PathException(string message)
      : base(message)
        {
        }
    }
}
