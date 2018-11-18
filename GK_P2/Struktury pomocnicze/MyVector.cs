using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK_P2.Struktury_pomocnicze
{
    public class MyVector
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }
        public MyVector(double x, double y, double z, bool zetEqualsOne = false)
        {
            if(zetEqualsOne)
            {
                if(z!=0)
                {
                    x = (x - 127) / z;
                    y = (y - 127) / z;
                }
                else
                {
                    x = y = 0;
                }
                z = 1;
            }
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
    public static class Math4Vectors
    {
        public static MyVector Multiply(this MyVector v, double c)
        {
            v.x *= c;
            v.y *= c;
            v.z *= c;
            return v;
        }
        public static double Cos(this MyVector N, MyVector L)
        {
            return Math.Abs(N.x * L.x + N.y * L.y + N.z * L.z);
        }
        public static MyVector Add(this MyVector N, MyVector D, bool normalize = true)
        {
            N.x += D.x;
            N.y += D.y;
            N.z += D.z;
            if (normalize)
            {
                double div = Math.Sqrt(N.x * N.x + N.y * N.y + N.z * N.z);
                if (div != 0)
                {
                    N.x /= div;
                    N.y /= div;
                    N.z /= div;
                }
                else
                    N.z = 1;
            }
            return N;
        }
        public static MyVector Normalize(this MyVector v)
        {
            double div = Math.Sqrt(v.x * v.x + v.y * v.y + v.z * v.z);
            if (div != 0)
            {
                v.x /= div;
                v.y /= div;
                v.z /= div;
            }
            else
                v.z = 1;
            return v;
        }
    }
}
