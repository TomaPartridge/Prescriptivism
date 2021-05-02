using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace labathree_pr
{
    class Hexagon : FlatFigure//light
    {
        //double area;
        //double sidesum;
        bool regular=true;
        double a;
        public bool Regular
        {
            get { return regular; }
        }
        public double Small_r
        {
            get { return a * Math.Sqrt(3) / 2; }
            set {a = Math.Sqrt(3) / (2 * value); }
        }
        public double Big_R
        {
            get { return a; }
            set { a = value; }
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
            set { a=Math.Sqrt(2 * value / (3 * Math.Sqrt(3))); }
        }
        public override double SideSum 
        {
            get { return DefPerimeter(); }
            set { a = value / 6; }
        }

        public Hexagon()
        { }
        public Hexagon(double a)
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
            return base.Inf() +$", правильный, a={a:0.00}";
        }
        public override void Draw(Graphics g)
        {
            Pen myWind = new Pen(Color.Yellow, 2);
            g.DrawPolygon(myWind, new Point[] { new Point(125, 378), new Point(175, 378), new Point(200, 408), new Point(175, 438), new Point(125, 438), new Point(100, 408) });
        }
    }
}

//Алгоритм нахождения площади шестиугольника:
//1. Создать класс вершина
//2. Класс ребро содержит номера вершин
//3. определить крайнюю левую вершину
//4. найти направление обхода фигуры против часовой стрелки
//5. обойти фигуру, записывая вершины в массив
//6. применить координатный метод для определения площади
//    ...
