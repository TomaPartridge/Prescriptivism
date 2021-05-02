using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace labathree_pr
{
    class Hexagon1 : FlatFigure//рассмотрены только правильные шестиугольники
    {
        bool regular = true;
        double a;
        double small_r;

        public bool Regular//правильный
        {
            get { return regular; }
        }
        public double Small_r
        {
            get { return small_r; }
            set { small_r= value; Reculc(); }
        }        
        public double Big_R
        {
            get { return a; }
            set { a = value; }
        }

        void Reculc()
        {
            a= Math.Sqrt(3) / (2 * small_r);
        }
        public override string Name
        {
            get { return "Шестиугольник"; }
        }

        public override int Angle
        {
            get { return 6; }
        }

        public override double Area
        {
            get { return DefArea(); }
            set { a = Math.Sqrt(2 * value / (3 * Math.Sqrt(3))); }
        }
        public override double SideSum
        {
            get { return DefPerimeter(); }
            set { a = value / 6; }
        }

        public Hexagon1()
        { }
        public Hexagon1(double a)
        {
            this.a = a;
        }
        public override object Clone()
        {
            return new Hexagon(a);
        }

        public override int CompareTo(object obj)
        {
            Hexagon hex2 = obj as Hexagon;
            if (hex2 != null)
                return this.Area.CompareTo(hex2.Area);
            else
                throw new Exception("Килограмм ваты легче килограмма железа");
        }

        public override double DefArea()
        {
            return a * a * Math.Sqrt(3) * 6 / 4;
        }

        public override double DefPerimeter()
        {
            return a * 6;
        }
        public override string Inf()
        {
            return base.Inf() + $", правильный, a={a:0.00}";
        }
        public override void Draw(Graphics g)
        {
            Pen myWind = new Pen(Color.Yellow, 2);
            g.DrawPolygon(myWind, new Point[] { new Point(125, 378), new Point(175, 378), new Point(200, 408), new Point(175, 438), new Point(125, 438), new Point(100, 408) });
        }
    }
}


