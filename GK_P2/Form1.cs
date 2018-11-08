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
        Point[] vertices = new Point[6];
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
            vertices[0] = new Point(20, 20);
            vertices[1] = new Point(100, 100);
            vertices[2] = new Point(20, 100);
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
                    for (int i = 0; i < vertices.Length; ++i)
                    {
                        if ((vertices[i].X >= e.X - 2 * r && vertices[i].X <= e.X + 2 * r) && (vertices[i].Y >= e.Y - 2 * r && vertices[i].Y <= e.Y + 2 * r))
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
                vertices[chosen_vertex] = new Point(e.X, e.Y);
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
            {
                g.DrawLine(p, vertices[i], vertices[(i + 1) % 3]);
            }
            for (int i = 3; i < 5; ++i)
            {
                g.DrawLine(p, vertices[i], vertices[i + 1]);
            }
            g.DrawLine(p, vertices[5], vertices[3]);

            //Wierzchłoki
            foreach (var v in vertices)
            {
                g.FillEllipse(new SolidBrush(Color.Black), v.X - r, v.Y - r, 2 * r, 2 * r);
            }
            for (int i = 0; i < vertices.Length; ++i)
            {
                if (i == chosen_vertex)
                    g.FillEllipse(new SolidBrush(Color.Red), vertices[i].X - r, vertices[i].Y - r, 2 * r, 2 * r);
                else
                    g.FillEllipse(new SolidBrush(Color.Black), vertices[i].X - r, vertices[i].Y - r, 2 * r, 2 * r);
            }
        }

        private void Fill()
        {
            

        }
    }
}
