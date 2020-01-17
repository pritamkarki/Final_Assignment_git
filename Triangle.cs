using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Assignment
{
    class Triangle : FinalShape
    {

        public void DrawShape(string[] result, Graphics graph, int x_axis, int y_axis, int radius, int width, int height)
        {
            Pen p = new Pen(Color.Red, 4);
            if (x_axis <= 50 || y_axis <= 50)
            {
                Random r = new Random();
                x_axis = r.Next(50, 300);
                y_axis = r.Next(50, 300);
            }
            Point[] points = new Point[3];
            points[0] = new Point(x_axis, Convert.ToInt32(result[1]));
            points[1] = new Point(y_axis, Convert.ToInt32(result[2]));
            points[2] = new Point(x_axis, Convert.ToInt32(result[3]));
            graph.DrawPolygon(p, points);
        }
    }
}

