using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labathree_pr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Trapezoid t1 = new Trapezoid(3, 5, 2, 2) { Area = 15, SideSum = 40 };
        Trapezoid t2 = new Trapezoid() { SideSum = 10, Area = 15 };
        Trapezoid t3 = new Trapezoid(1, 2, 3, 3.5);
        Parallelogram p1 = new Parallelogram(4, 4, 30);
        Parallelogram p2 = new Parallelogram() { Area = 10, SideSum = 13.1 };
        Parallelogram p3 = new Parallelogram(4, 5, 30);
        Hexagon h1 = new Hexagon(5);
        Hexagon h2 = new Hexagon() { Area = 30 };
        Hexagon h3 = new Hexagon() { Small_r = 1 };
        private void button1_Click2(object sender, EventArgs e)
        {            
            t3.DefArea();
            t3.DefPerimeter();            

            FlatFigure[] trap = new FlatFigure[] { t1, t2, t3 };
            FlatFigure[] par = new FlatFigure[] { p1, p2, p3 };
            FlatFigure[] hex = new FlatFigure[] { h1, h2, h3 };

            listBox1.Items.Add("_________________________");
            listBox1.Items.Add("Трапеции");
            foreach (FlatFigure el in trap)
            {
                listBox1.Items.Add(el.Inf());
            }
            listBox1.Items.Add("Параллелограммы");
            foreach (FlatFigure el in par)
            {
                listBox1.Items.Add(el.Inf());
            }
            listBox1.Items.Add("Шестиугольники");
            foreach (FlatFigure el in hex)
            {
                listBox1.Items.Add(el.Inf());
            }
        }

        private void button2_Click2(object sender, EventArgs e)
        {            
            Trapezoid t2 = (Trapezoid)t1.Clone();            
            Parallelogram p2 = (Parallelogram)p1.Clone();            
            Hexagon cru = (Hexagon)h1.Clone();
            cru.Big_R = 5;
            t2.DefArea();
            listBox1.Items.Add("__________");
            CloneWriter(t1, t2);
            CloneWriter(p1, p2);
            CloneWriter(h1, cru);
            listBox1.Items.Add("__________");
        }

        void CloneWriter(FlatFigure figure1, FlatFigure figure2)
        {
            listBox1.Items.Add("Оригинал | " + figure1.Inf());
            listBox1.Items.Add("Клон         | " + figure2.Inf());
        }

        private void button3_Click2(object sender, EventArgs e)
        {
            listBox1.Items.Add("------------------------------");
                      

            Trapezoid[] trap = new Trapezoid[] { t1, t2, t3 };//я запуталась, справа и слева одно и то же
            Parallelogram[] par = new Parallelogram[] { p1, p2, p3 };
            Hexagon[] hex = new Hexagon[] { h1, h2, h3 };

            Array.Sort(trap, new TrComp());
            Array.Sort(par, new ParComp());
            Array.Sort(hex, new HexComparer());

            listBox1.Items.Add("---Отсортированные трапеции---");
            foreach (var item in trap)
            {
                string str;
                try
                {
                    str = item.Inf();
                }
                catch
                {
                    str = $"название: {item.Name}, количество углов: {item.Angle}, " + (item.Isos ? $", трапеция равнобокая, а={item.a}; b={item.b}; c=d={item.c}" : $", а={item.a}; b={item.b}; c={item.c}; d={item.d}");
                }
                listBox1.Items.Add(str);
            }
            listBox1.Items.Add("---Отсортированные параллелограммы---");
            foreach (var item in par)
            {
                listBox1.Items.Add(item.Inf());
            }
            listBox1.Items.Add("---Отсортированные шестиугольники---");
            foreach (var item in hex)
            {
                listBox1.Items.Add(item.Inf());
            }
        }

        private void button4_Click2(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.Turquoise);
            new Trapezoid().Draw(g);
            new Parallelogram().Draw(g);
            new Hexagon().Draw(g);

            //// Объявляем объект "g" класса Graphics и предоставляем
            //// ему возможность рисования на pictureBox1:

            //// Создаем объекты-кисти для закрашивания фигур

            ////Выбираем перо myPen желтого цвета толщиной в 2 пикселя:

            //// Закрашиваем фигуры
            // (трапеция)
            //(прямоугольник)

            ////g.DrawPolygon(myWind, new Point[]{new Point(125, 408),  new Point(175, 408), new Point(200, 423), new Point(175, 438), new Point(125, 438), new Point(100, 423)});



        }
    }
}
