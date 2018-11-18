using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK_P2.Struktury_pomocnicze
{
    public class Edge
    {
        public Point p1 { get; set; }
        public Point p2 { get; set; }
        public Edge(Point _p1,Point _p2)
        {
            p1 = _p1;
            p2 = _p2;
        }
    }
    public static class EdgeExtensions
    {
        /**zwraca punkt przecięcia krawędzi edge z prostą scanLine */
        public static int Intersection(this Edge edge, int scanLine)
        {
            if(edge.p1.X==edge.p2.X)
                return edge.p1.X;
            else
            {
                double y1 = edge.p1.Y, y2 = edge.p2.Y, x1 = edge.p1.X, x2 = edge.p2.X;
                double a = (y1-y2) / (x1-x2);
                double b = edge.p1.Y - a * edge.p1.X;
                if (a == 0)
                    return (int)b;
                return (int)((scanLine-b)/a);
            }
        }
    }

    
}
