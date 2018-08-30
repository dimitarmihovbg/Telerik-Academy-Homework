using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineOOP
{
    public class DisplayCharacteristics
    {
        public int Size { get; set; }
        public int NumColors { get; set; }

        public DisplayCharacteristics(int size, int numColors)
        {
            this.Size = size;
            this.NumColors = numColors;
        }
    }
}
