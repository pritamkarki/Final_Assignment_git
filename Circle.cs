using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ASE_Assignment
{
    class Circle : Shape
    {
        public void DrawShape(string[] res, Graphics graph, int x_axis, int y_axis)
        {
            int x_axis1 = Convert.ToInt32(res[1]);
            int y_axis1 = Convert.ToInt32(res[1]);
            Pen p = new Pen(Color.Red, 4);
            graph.DrawEllipse(p, x_axis, y_axis, x_axis1, y_axis1);
        }
    }
}




