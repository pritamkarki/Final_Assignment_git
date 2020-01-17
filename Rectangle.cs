using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ASE_Assignment
{
    class Rectangle : FinalShape
    {
        public void DrawShape(string[] result, Graphics graph, int x_axis, int y_axis, int radius, int width, int height)
        {
            int x_axis1 = Convert.ToInt32(result[1]);
            int y_axis1 = Convert.ToInt32(result[2]);
            Pen p = new Pen(Color.BlueViolet, 5);
            graph.DrawRectangle(p, x_axis, y_axis, x_axis1, y_axis1);
            
        }
    }
}
