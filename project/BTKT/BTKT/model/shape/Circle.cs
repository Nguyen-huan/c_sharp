using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKT.model.shape
{
    public class Circle:iShape
    {
        private float r;
        public Circle() { }
        public Circle(float r)
        {
            this.r = r;
        }
        public float Area()
        {
            return (float)Math.PI*r*r;
        }
    }
}
