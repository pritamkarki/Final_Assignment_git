using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ASE_Assignment
{
    class Circle : FinalShape
    {
        int xaxis = 0, yaxis = 0;
        public void DrawShape(string[] result, Graphics graph, int x_axis, int y_axis, int radius,int width,int height)
        {
            if (radius != 0)
            {
                xaxis = radius;
                yaxis = radius;
            }

            else
            {

                 xaxis = Convert.ToInt32(result[1]);
                yaxis = Convert.ToInt32(result[1]);
            }
            Pen p = new Pen(Color.Red, 4);
            graph.DrawEllipse(p, x_axis, y_axis, xaxis, yaxis);
        }

        
    }
}
