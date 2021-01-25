using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToiUuHoaHinhHoc
{
    internal class Line
    {
        public float a, b, c; //ax + by + c = 0

        public Line() {
        }

        public Line(float aa, float bb, float cc) {
            a = aa;
            b = bb;
            c = cc;
        }

        public float f(PointF p) {
            return a * p.X + b * p.Y + c;
        }

        public static bool areParallel(Line l1, Line l2) {
            return l1.a * l2.b == l1.b * l2.a;
        }

        public static PointF findIntersect(Line l1, Line l2) {
            if (areParallel(l1, l2)) return new PointF(-1, -1);
            float dx = l1.b * l2.c - l2.b * l1.c;
            float dy = l1.c * l2.a - l2.c * l1.a;
            float d = l1.a * l2.b - l2.a * l1.b;
            return new PointF(dx / d, dy / d);
        }
    }
}