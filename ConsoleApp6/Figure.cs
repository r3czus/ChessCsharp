using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public abstract class Figure
    {
        public bool isWhite { get; set; }
        public string kind { get; set; }
        public int curentlyPositionX { get; set; }
        public int curentlyPositionY { get;set; }

        public abstract string AllowedMove();






    }
}
