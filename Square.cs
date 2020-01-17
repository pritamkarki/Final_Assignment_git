using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Assignment
{
    class Square :FinalShape
    {
public void DrawShape(string[] result, Graphics graph, int x_axis, int y_axis, int radius, int width, int height)
        {

            int a = 0, b = 0;

            a = Convert.ToInt32(result[1]);
            b = Convert.ToInt32(result[1]);

            Pen p = new Pen(Color.Bisque, 3);
            graph.DrawRectangle(p, x_axis, y_axis, a, b);
        }
    }
}
