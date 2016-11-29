using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echelon
{
    public class Move
    {
        public Matrix from;
        public Matrix to;
        public List<string> Details;
        public Move()
        {
            this.Details = new List<string>();
        }
    }
}
