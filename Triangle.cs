using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Assignment
{
    class Triangle : Shape
    {

        public void DrawShape(string[] res, Graphics g, int k, int l)
        {
            Pen p = new Pen(Color.Red, 4);
            if (k <= 50 || l <= 50)
            {
                Random r = new Random();
                k = r.Next(50, 300);
                l = r.Next(50, 300);
            }
            Point[] points = new Point[3];
            points[0] = new Point(k, Convert.ToInt32(res[1]));
            points[1] = new Point(l, Convert.ToInt32(res[2]));
            points[2] = new Point(k, Convert.ToInt32(res[3]));
            g.DrawPolygon(p, points);
        }
    }
}

