using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK_P2
{
    public partial class Form1 : Form
    {
        Point[] v = new Point[6];
        Point[] ind1 = new Point[3];
        Point[] ind2 = new Point[3];
        int w, h, r = 5;
        int chosen_vertex = 0; //indeks wierzchołka, którym chcemy poruszać
        bool canMove = false;
        // 0 1 2 - 1szy trójkąt
        // 3 4 5 - 2gi trójkąt
        public Form1()
        {
            InitializeComponent();
            pBox.Image = new Bitmap(pBox.Size.Width, pBox.Size.Height);
            w = pBox.Image.Width;
            h = pBox.Image.Height;
            DrawExamplePolygons();
            FillPolygons();
            Redraw();
        }

        private void pBox_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                if (canMove)
                    canMove = false;
                else
                {
                    for (int i = 0; i < v.Length; ++i)
                    {
                        if ((v[i].X >= e.X - 2 * r && v[i].X <= e.X + 2 * r) && (v[i].Y >= e.Y - 2 * r && v[i].Y <= e.Y + 2 * r))
                        {
                            chosen_vertex = i;
                            Redraw();
                            break;
                        }
                    }
                }
            }
            if(e.Button==MouseButtons.Right)
                canMove = true;
        }
        private void pBox_MouseMove(object sender, MouseEventArgs e)
        {
            if(canMove)
            {
                v[chosen_vertex] = new Point(e.X, e.Y);
                Redraw();
            }
        }
        private void Redraw()
        {
            Image img = new Bitmap(w,h);
            if (pBox.Image != null)
                pBox.Image.Dispose();
            Graphics g = Graphics.FromImage(pBox.Image = img);

            //Krawędzie
            Pen p = new Pen(Color.Black);
            for (int i = 0; i < 3; ++i)
                g.DrawLine(p, v[i], v[(i + 1) % 3]);
            for (int i = 3; i < 5; ++i)
                g.DrawLine(p, v[i], v[i + 1]);
            g.DrawLine(p, v[5], v[3]);

            //Wierzchłoki
            foreach (var v in v)
                g.FillEllipse(new SolidBrush(Color.Black), v.X - r, v.Y - r, 2 * r, 2 * r);
            for (int i = 0; i < v.Length; ++i)
                if (i == chosen_vertex)
                    g.FillEllipse(new SolidBrush(Color.Red), v[i].X - r, v[i].Y - r, 2 * r, 2 * r);
                else
                    g.FillEllipse(new SolidBrush(Color.Black), v[i].X - r, v[i].Y - r, 2 * r, 2 * r);
            
        }
        private void DrawExamplePolygons()
        {
            v[0] = new Point(20, 20);
            v[1] = new Point(100, 100);
            v[2] = new Point(20, 100);

            v[3] = new Point(200, 20);
            v[4] = new Point(200, 100);
            v[5] = new Point(50, 120);

            for (int i = 0; i < v.Length; ++i)
                if (i < 3)
                    ind1[i] = v[i];
                else
                    ind2[i - 3] = v[i];
        }
        private void FillPolygons()
        {
            Array.Sort(ind1, (a, b) =>
            {
                return a.Y - b.Y;
            });
            int yMin1 = ind1[0].Y;
            int yMax1 = ind1[2].Y;

            Array.Sort(ind2, (a, b) => a.Y - b.Y);
            int yMin2 = ind2[0].Y;
            int yMax2 = ind2[2].Y;
        }
    }
}
