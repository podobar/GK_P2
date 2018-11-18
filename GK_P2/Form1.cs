﻿using GK_P2.Struktury_pomocnicze;
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
        List<Edge> aet1 = new List<Edge>();
        List<Edge> aet2 = new List<Edge>();

        DirectBitmap bitmap = null;
        DirectBitmap TextureMap = new DirectBitmap(GK_P2.Properties.Resources.normalMap2);
        DirectBitmap NormalMap = new DirectBitmap(GK_P2.Properties.Resources.normalMap1);
        DirectBitmap HeightMap = new DirectBitmap(GK_P2.Properties.Resources.heightMap1);
        
        Point circlePoint; 
        int angle = 20;
        int sphereRadius;
        int z = 100;

        Color constObjectColor = Color.White;

        static int w, h, r = 10;
        int chosen_vertex = 0; //indeks wierzchołka, którym chcemy poruszać
        bool canMove = false;
        bool moved = true;
        public Form1()
        {
            InitializeComponent();
            pBox.Image = new Bitmap(pBox.Size.Width, pBox.Size.Height);
            w = pBox.Image.Width;
            h = pBox.Image.Height;
            ocPBox2.Image = TextureMap.Bitmap.GetThumbnailImage(ocPBox2.Width, ocPBox2.Height, () => false, IntPtr.Zero);
            normalMapPBox.Image = NormalMap.Bitmap.GetThumbnailImage(normalMapPBox.Width, normalMapPBox.Height, () => false, IntPtr.Zero);
            heightMapPBox.Image = HeightMap.Bitmap.GetThumbnailImage(heightMapPBox.Width, heightMapPBox.Height, () => false, IntPtr.Zero);
            DrawExamplePolygons();
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
                moved = true;
                Redraw();
            }
        }
        private void Redraw()
        {
            if (bitmap != null)
                bitmap.Dispose();
            bitmap = new DirectBitmap(w, h);
            pBox.Image = bitmap.Bitmap;
            FillPolygons();
        }
        private void FillPolygons()
        {
            if(moved)
            {
                for (int i = 0; i < ind1.Length; ++i)
                {
                    ind1[i] = v[i];
                    ind2[i] = v[i + 3];
                }
                Array.Sort(ind1, (a, b) =>
                {
                    return a.Y - b.Y;
                });
                Array.Sort(ind2, (a, b) =>
                {
                    return a.Y - b.Y;
                });
                moved = false;
            }
            int yMin1 = ind1[0].Y;
            int yMax1 = ind1[2].Y;
            int yMin2 = ind2[0].Y;
            int yMax2 = ind2[2].Y;
            
            for (int y = yMin1+1; y <= yMax1+1; ++y)
            {// tylko dla ind1
                foreach(var vertex in ind1)
                {
                    if(vertex.Y==y-1)
                    {
                        int i=Array.IndexOf(ind1, vertex);
                        if(i==0)
                        {
                            if (ind1[2].Y > vertex.Y)
                                aet1.Add(new Edge(ind1[2], ind1[0]));
                            else
                                aet1.RemoveAll(e =>
                                {
                                    return (e.p1 == ind1[2] && e.p2 == ind1[0]) || (e.p1 == ind1[0] && e.p2 == ind1[2]);
                                });
                               
                            if(ind1[1].Y > vertex.Y)
                                aet1.Add(new Edge(ind1[1], ind1[0]));
                            else
                                aet1.RemoveAll(e => 
                                {
                                    return (e.p1== ind1[1] && e.p2==ind1[0]) || (e.p1==ind1[0] && e.p2==ind1[1]);
                                });
                        }
                        else
                        {
                            if (ind1[i-1].Y > vertex.Y)
                                aet1.Add(new Edge(ind1[i-1], ind1[i]));
                            else
                                aet1.RemoveAll(e =>
                                {
                                    return (e.p1 == ind1[i-1] && e.p2 == ind1[i]) || (e.p1 == ind1[i] && e.p2 == ind1[i-1]);
                                });
                                
                            if (ind1[(i + 1)% 3].Y > vertex.Y)
                                aet1.Add(new Edge(ind1[i], ind1[(i+1)%3]));
                            else
                                aet1.RemoveAll(e =>
                                {
                                    return (e.p1 == ind1[i] && e.p2 == ind1[(i + 1) % 3]) || (e.p1 == ind1[(i + 1) % 3] && e.p2 == ind1[i]);
                                });
                        }
                    }
                }
                aet1.Sort((e1, e2) => Math.Min(e1.p1.X, e1.p2.X) - Math.Min(e2.p1.X, e2.p2.X));
                Parallel.For(0, aet1.Count, i =>
                {
                    if(i%2 == 0)
                    {
                        int x1 = aet1[i].Intersection(y);
                        int x2 = aet1[i + 1].Intersection(y);
                        ApplyColor(Math.Min(x1, x2), Math.Max(x1, x2), y);
                    }
                });
                
            }
            for (int y = yMin2 + 1; y <= yMax2 + 1; ++y)
            {// tylko dla ind2
                foreach (var vertex in ind2)
                {
                    if (vertex.Y == y - 1)
                    {
                        int i = Array.IndexOf(ind2, vertex);
                        if (i == 0)
                        {
                            if (ind2[2].Y > vertex.Y)
                                aet2.Add(new Edge(ind2[2], ind2[0]));
                            else
                                aet2.RemoveAll(e =>
                                {
                                    return (e.p1 == ind2[2] && e.p2 == ind2[0]) || (e.p1 == ind2[0] && e.p2 == ind2[2]);
                                });

                            if (ind2[1].Y > vertex.Y)
                                aet2.Add(new Edge(ind2[1], ind2[0]));
                            else
                                aet2.RemoveAll(e =>
                                {
                                    return (e.p1 == ind2[1] && e.p2 == ind2[0]) || (e.p1 == ind2[0] && e.p2 == ind2[1]);
                                });
                        }
                        else
                        {
                            if (ind2[i - 1].Y > vertex.Y)
                                aet2.Add(new Edge(ind2[i - 1], ind2[i]));
                            else
                                aet2.RemoveAll(e =>
                                {
                                    return (e.p1 == ind2[i - 1] && e.p2 == ind2[i]) || (e.p1 == ind2[i] && e.p2 == ind2[i - 1]);
                                });

                            if (ind2[(i + 1) % 3].Y > vertex.Y)
                                aet2.Add(new Edge(ind2[i], ind2[(i + 1) % 3]));
                            else
                                aet2.RemoveAll(e =>
                                {
                                    return (e.p1 == ind2[i] && e.p2 == ind2[(i + 1) % 3]) || (e.p1 == ind2[(i + 1) % 3] && e.p2 == ind2[i]);
                                });
                        }
                    }
                }
                aet2.Sort((e1, e2) => Math.Min(e1.p1.X, e1.p2.X) - Math.Min(e2.p1.X, e2.p2.X));
                Parallel.For(0, aet2.Count, i =>
                {
                    if (i % 2 == 0)
                    {
                        int x1 = aet2[i].Intersection(y);
                        int x2 = aet2[i + 1].Intersection(y);
                        ApplyColor(Math.Min(x1, x2), Math.Max(x1, x2), y);
                    }
                });
            }
        }
        private void sphereRadiusChangeButton_Click(object sender, EventArgs e)
        {
            sphereRadius = (int)sphereRadiusUpDown.Value;
        }
        private void lightColorButton_Click(object sender, EventArgs e)
        {
            var choose_wisely = new ColorDialog
            {
                AllowFullOpen = true
            };
            if (choose_wisely.ShowDialog() == DialogResult.OK)
            {
                lightColorPbox.BackColor = choose_wisely.Color;
                Redraw();
            }
                
        }
        private void normalMapChangeButton_Click(object sender, EventArgs e)
        {
            if(LoadTexture(ref NormalMap) && normalVectorNormalMapRB.Checked)
            {
                normalMapPBox.Image.Dispose();
                normalMapPBox.Image = NormalMap.Bitmap.GetThumbnailImage(normalMapPBox.Width, normalMapPBox.Height, () => false, IntPtr.Zero);
                Redraw();
            }
        }
        private void ocConstRB_CheckedChanged(object sender, EventArgs e)
        {
            if (ocConstRB.Checked)
            {
                constObjectColor = ocPBox.BackColor;
                Redraw();
            }
        }
        private void ocConstChangeButton_Click(object sender, EventArgs e)
        {
            var choose_wisely = new ColorDialog
            {
                AllowFullOpen = true
            };
            if (choose_wisely.ShowDialog() == DialogResult.OK)
            {
                constObjectColor = ocPBox.BackColor = choose_wisely.Color;
                if (ocConstRB.Checked)
                {
                    Redraw();
                }
            }
        }
        private void ocTextureRB_CheckedChanged(object sender, EventArgs e)
        {
            if (ocTextureRB.Checked)
            {
                if (TextureMap == null)
                {
                    if (LoadTexture( ref TextureMap) == false)
                        ocConstRB.Checked = true;
                    else
                        Redraw();
                }
                else
                    Redraw();
            }
        }
        private void ocTextureButton_Click(object sender, EventArgs e)
        {
            if (LoadTexture( ref TextureMap) && ocTextureRB.Checked)
            {
                ocPBox2.Image.Dispose();
                ocPBox2.Image = TextureMap.Bitmap.GetThumbnailImage(ocPBox2.Width, ocPBox2.Height, () => false, IntPtr.Zero);
                Redraw();
            }
        }
        private void normalVectorNormalMapRB_CheckedChanged(object sender, EventArgs e)
        {
            if (normalVectorNormalMapRB.Checked)
            {
                if (NormalMap == null)
                {
                    if (LoadTexture(ref NormalMap) == false)
                        normalVectorConstRB.Checked = true;
                    else
                        Redraw();
                }
                else
                    Redraw();
            }
               
        }
        private void normalVectorConstRB_CheckedChanged(object sender, EventArgs e)
        {
            if (normalVectorConstRB.Checked)
                Redraw();
        }
        private void disturbanceNoneRB_CheckedChanged(object sender, EventArgs e)
        {
            if (disturbanceNoneRB.Checked)
                Redraw();
        }
        private void disturbanceHeightMapRB_CheckedChanged(object sender, EventArgs e)
        {
            if (disturbanceHeightMapRB.Checked)
            {
                if (HeightMap == null)
                {
                    if (LoadTexture(ref HeightMap) == false)
                        disturbanceNoneRB.Checked = true;
                    else
                        Redraw();
                }
                else
                    Redraw();
            }
        }
        private void disturbanceHeightMapChangeButton_Click(object sender, EventArgs e)
        {
            if (LoadTexture(ref HeightMap) && disturbanceHeightMapRB.Checked)
            {
                heightMapPBox.Image.Dispose();
                heightMapPBox.Image = HeightMap.Bitmap.GetThumbnailImage(heightMapPBox.Width, heightMapPBox.Height, () => false, IntPtr.Zero);
                Redraw();
            }
        }
        private void constLVectorRB_CheckedChanged(object sender, EventArgs e)
        {
            if (constLVectorRB.Checked)
            {
                sphereTimer.Stop();
                Redraw();
            }
        }
        private void sphericaLVectorRB_CheckedChanged(object sender, EventArgs e)
        {
            if (sphericaLVectorRB.Checked)
            {
                sphereRadius = (int)sphereRadiusUpDown.Value;
                sphereTimer.Start();
            }
        }
        private void lightSourceColorReflectorsRB_CheckedChanged(object sender, EventArgs e)
        {
            if (lightSourceColorReflectorsRB.Checked)
            {
                Redraw();
            }
        }
        private void lightSourceConstColorRB_CheckedChanged(object sender, EventArgs e)
        {
            if (lightSourceConstColorRB.Checked)
                Redraw();
        }
        private void ApplyColor(int start, int end, int y)
        {
            Parallel.For(start, end + 1, i =>
            {
                MyVector N = new MyVector(0, 0, 1);
                MyVector L = new MyVector(0, 0, 1);
                MyVector D = new MyVector(0, 0, 0);
                double R, G, B;
                if (lightSourceConstColorRB.Checked)
                {
                    R = (lightColorPbox.BackColor.R / 255.0);
                    G = (lightColorPbox.BackColor.G / 255.0);
                    B = (lightColorPbox.BackColor.B / 255.0);
                }
                else
                {
                    MyVector rR = new MyVector(w / 2, h / 2, z).Normalize();
                    MyVector RPoint = new MyVector(i, y, z).Normalize();
                    MyVector rG = new MyVector(w / 2, -h / 2, z).Normalize();
                    MyVector GPoint = new MyVector(w-i, -y, z).Normalize();
                    MyVector rB = new MyVector(0, h / 2, z).Normalize();
                    MyVector BPoint = new MyVector(w/2 - i, h-y, z).Normalize();
                    double cosR = Math4Vectors.Cos(rR, RPoint);
                    double cosG = Math4Vectors.Cos(rG, GPoint);
                    double cosB = Math4Vectors.Cos(rB, BPoint);
                    R = Math.Pow(cosR, 20);
                    G = Math.Pow(cosG, 20);
                    B = Math.Pow(cosB, 10);
                }
                //Kolor obiektu
                if (ocTextureRB.Checked)
                {
                    Color toSet = TextureMap.GetPixel(i % (TextureMap.Width - 1) + 1, y % (TextureMap.Height - 1) + 1);
                    R *= (toSet.R / 255.0);
                    G *= (toSet.G / 255.0);
                    B *= (toSet.B / 255.0);
                }
                else
                {
                    R *= (constObjectColor.R / 255.0);
                    G *= (constObjectColor.G / 255.0);
                    B *= (constObjectColor.B / 255.0);
                }
                //N
                if (normalVectorConstRB.Checked==false)
                {
                    Color fromNormal = NormalMap.GetPixel(i % (NormalMap.Width - 1) + 1, y % (NormalMap.Height - 1) + 1);
                    N = new MyVector(fromNormal.R, fromNormal.G, fromNormal.B, true);
                }
                //D
                if (disturbanceNoneRB.Checked==false)
                {
                    Color Xplus = HeightMap.GetPixel((i + 1) % (HeightMap.Width - 1) + 1, y % (HeightMap.Height - 1) + 1);
                    Color Yplus = HeightMap.GetPixel(i % (HeightMap.Width - 1) + 1, (y + 1) % (HeightMap.Height - 1) + 1);
                    Color fromHeight = HeightMap.GetPixel(i % (HeightMap.Width - 1) + 1, y % (HeightMap.Height - 1) + 1);
                    int dhX = (Xplus.R + Xplus.G + Xplus.B - fromHeight.R - fromHeight.G - fromHeight.B)/3;
                    int dhY = (Yplus.R + Yplus.G + Yplus.B - fromHeight.R - fromHeight.G - fromHeight.B)/3;
                    MyVector T = new MyVector(1, 0, -(Xplus.R + Xplus.G + Xplus.B));
                    MyVector Bb = new MyVector(0, 1, -(Yplus.R + Yplus.G + Yplus.B));
                    D = Math4Vectors.Add(T.Multiply(dhX), Bb.Multiply(dhY));
                }
                //L
                if(constLVectorRB.Checked==false)
                {
                    L = new MyVector(circlePoint.X - i, -(circlePoint.Y - y), z).Normalize();
                }
                //Cos(N',L)
                var Nprim = Math4Vectors.Add(N, D);
                double Cos = Math4Vectors.Cos(Nprim, L);
                R *= Cos*255;
                G *= Cos*255;
                B *= Cos*255;

                if (R > 255)
                    R = 255;
                if (R < 0)
                    R = 0;
                if (G > 255)
                    G = 255;
                if (G < 0)
                    G = 0;
                if (B > 255)
                    B = 255;
                if (B < 0)
                    B = 0;
                bitmap.SetPixel(i, y, Color.FromArgb((int)R, (int)G, (int)B));
            });
        }
        private bool LoadTexture(ref DirectBitmap bmp)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Załaduj obraz";
                dialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp) | *.jpg; *.jpeg; *.png; *.bmp";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    bmp = new DirectBitmap(new Bitmap(dialog.FileName));
                    return true;
                }
            }
            return false;
        }
        private void DrawExamplePolygons()
        {
            v[0] = new Point(20, 29);
            v[1] = new Point(555, 20);
            v[2] = new Point(555, 500);

            v[3] = new Point(20, 40);
            v[4] = new Point(20, 550);
            v[5] = new Point(500, 550);

            for (int i = 0; i < v.Length; ++i)
                if (i < 3)
                    ind1[i] = v[i];
                else
                    ind2[i - 3] = v[i];
        }
        private void countCirclePoint(object sender, EventArgs e)
        {
            int x = (int)(sphereRadius * Math.Cos(angle * Math.PI / 180F)) + w / 2;
            int y = (int)(sphereRadius * Math.Sin(angle * Math.PI / 180F)) + h / 2;
            angle = (angle + 20) % 360;
            circlePoint = new Point(x, y);
            Redraw();
        }
    }
}
