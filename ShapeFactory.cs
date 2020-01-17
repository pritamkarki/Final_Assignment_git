using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Assignment
{
    class ShapeFactory
    {
        public Shape getShape(string value)
        {
            if (value == "rectangle")
            {
                return new Rectangle();
            }
            else if (value == "triangle")
            {
                return new Triangle();
            }
            else if (value == "circle")
            {
                return new Circle();
            }
            return null;
        }
    }
}