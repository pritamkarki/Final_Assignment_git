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
        
        public void DrawShape(string[] result, Graphics graph, int x_axis, int y_axis, int radius,int width,int height)
        {
          
            
                int xaxis = Convert.ToInt32(result[1]);
                int yaxis = Convert.ToInt32(result[1]);
            
            Pen p = new Pen(Color.Red, 4);
            graph.DrawEllipse(p, x_axis, y_axis, xaxis, yaxis);
        }

        
    }
}
