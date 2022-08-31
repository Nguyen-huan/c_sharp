using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKT.model.shape
{
    public class Square:iShape
    {
        private float a;
        public Square() { }
        public Square(float a) 
        { 
            this.a = a; 
        }
        public float Area()
        {
            return a * a;
        }
        
    }
}
