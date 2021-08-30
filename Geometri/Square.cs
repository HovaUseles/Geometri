using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Square
    {
        // Object attribute
        private float side;

        // Constructor
        public float Side
        {
            get
            {
                return this.side;
            }
            set
            {
                this.side = value;
            }
        }

        public Square(float a)
        {
            this.side = a;
        }

        public Square()
        {
            // Empty Constructor
        }
        public float Perimeter()
        {
            return side * 4;
        }
        public float Area()
        {
            return side * side;
        }
    }
}
