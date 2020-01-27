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
        int xaxis = 0,yaxis=0;

        public void DrawShape(string[] result, Graphics graph, int x_axis, int y_axis, int radius, int width, int height)
        {
            if (width != 0 && height != 0)
            {
                xaxis = width;
                yaxis = height;
            }
            else
            {
                try
                {
                    xaxis = Convert.ToInt32(result[1]);
                    yaxis= Convert.ToInt32(result[2]);
                }
                catch (Exception e)
                {

                }

            }
           
            Pen p = new Pen(Color.BlueViolet, 5);
            graph.DrawRectangle(p, x_axis, y_axis, xaxis, yaxis);
            
        }
    }
}
