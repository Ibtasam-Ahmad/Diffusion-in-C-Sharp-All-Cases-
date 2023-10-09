using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diffusion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
            double D = 1, dx = 1, dt = 0.5;
            double sigma;
            double[,] rho = new double[100, 100];
            int x = -50;
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    sigma = Math.Sqrt(2 * D * (j + 1));
                    rho[i, j] = 1 / sigma * (Math.Exp(-(x * x) / (2 * sigma * sigma)));
                }
                x++;
            }
            for (int i = 1; i < 100-1; i++)
            {
                for (int j = 0; j < 100-1; j++)
                {
                    rho[i, j + 1] = rho[i, j] + (dt / (dx * dx)) * D * (rho[i + 1, j] - 2 * rho[i, j] + rho[i - 1, j]);
                }
            }
            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Black);
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    gg.FillEllipse(sb, 200 + i*2, 400 - (float)rho[i, j]*1500, 5, 5);
                }
            }
        }

        private void dclassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
            double D = 1, dx = 1, dt = 0.5;
            int size = 100,x=-50;
            diffusion_cl obj = new diffusion_cl(this, D,dx, dt,x, size);
            obj.plot();
            
        }

        private void dthroughrandomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double xc = cube.ClientSize.Width / 2;
            double yc = cube.ClientSize.Height / 2;
            double xmin = xc - 10, xmax = xc + 10, ymax = yc + 10, ymin = yc - 10;
            double xleft = xc - xc, xright = xc + xc, yup = yc - yc, ydown = yc + yc;
            Random rnd = new Random();
            double prob, px, py;
            int mole = 100;
            Point[] particle = new Point[mole];
            Graphics gg = cube.CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.White);
            SolidBrush sb1 = new SolidBrush(Color.Black);
            for (int i = 0; i < mole; i++)
            {
                prob = rnd.NextDouble();
                px = xmin + (xmax - xmin) * prob;
                prob = rnd.NextDouble();
                py = ymin + (ymax - ymin) * prob;
                particle[i].X = (int)px;
                particle[i].Y = (int)py;
                gg.FillEllipse(sb, particle[i].X, particle[i].Y, 5, 5);
                
            }
           
            while (true)
            {
                Thread.Sleep(100);
                for (int i = 0; i < mole; i++)
                {
                    gg.FillEllipse(sb1, particle[i].X, particle[i].Y, 5, 5);
                    prob = rnd.NextDouble();
                    if (prob < 0.5)
                    {
                        particle[i].X = particle[i].X + 2;
                    }
                    else
                    {
                        particle[i].X = particle[i].X - 2;
                    }
                    prob = rnd.NextDouble();
                    if (prob < 0.5)
                    {
                        particle[i].Y = particle[i].Y + 2;
                    }
                    else
                    {
                        particle[i].Y = particle[i].Y - 2;
                    }
                    //apply constriant
                    if (particle[i].X < xleft)
                        particle[i].X = (int)xleft;
                    else if (particle[i].X > xright)
                        particle[i].X = (int)xright;
                    if (particle[i].Y < yup)
                        particle[i].Y = (int)yup;
                    else if (particle[i].Y > ydown)
                        particle[i].Y = (int)ydown;
                    gg.FillEllipse(sb, particle[i].X, particle[i].Y, 5, 5);
                  
                }
            }
        }

        private void dwithclassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics gg = cube.CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.White);
            SolidBrush sb1 = new SolidBrush(Color.Black);
            double xc = cube.ClientSize.Width / 2;
            double yc = cube.ClientSize.Height / 2;
            int inc = 10,mole=100;
            dif_2d obj = new dif_2d(xc, yc, inc,mole);
            obj.drop_set();
            while (true)
            {
                for (int i = 0; i < mole; i++)
                {
                    gg.FillEllipse(sb1, obj.particle[i].X, obj.particle[i].Y, 5, 5);
                    obj.dif_process(i);
                    gg.FillEllipse(sb, obj.particle[i].X, obj.particle[i].Y, 5, 5);
                    
                }
               
            }
        }

        private void ddirecclassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int size = 100, n = 10;
            dif_class_dire obj = new dif_class_dire(this,n,size);
            obj.drop();
            obj.dif_process();
        }

        private void entropyToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            double xc = cube.ClientSize.Width / 2;
            double yc = cube.ClientSize.Height / 2;
            double xmin = xc - 10, xmax = xc + 10, ymax = yc + 10, ymin = yc - 10;
            double xleft = xc - xc, xright = xc + xc, yup = yc - yc, ydown = yc + yc;
            Random rnd = new Random();
            double prob, px, py;
            int mole = 100;
            double t = 0;
            Point[] particle = new Point[mole];
            Graphics gg = cube.CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.White);
            SolidBrush sb1 = new SolidBrush(Color.Black);
            for (int i = 0; i < mole; i++)
            {
                prob = rnd.NextDouble();
                px = xmin + (xmax - xmin) * prob;
                prob = rnd.NextDouble();
                py = ymin + (ymax - ymin) * prob;
                particle[i].X = (int)px;
                particle[i].Y = (int)py;
                gg.FillEllipse(sb, particle[i].X, particle[i].Y, 5, 5);

            }

            while (true)
            {
                //Thread.Sleep(100);
                double[,] rho = new double[(int)(xc + xc), (int)(yc + yc)];
                for (int i = 0; i < mole; i++)
                {
                    gg.FillEllipse(sb1, particle[i].X, particle[i].Y, 5, 5);
                    prob = rnd.NextDouble();
                    if (prob < 0.5)
                    {
                        particle[i].X = particle[i].X + 2;
                    }
                    else
                    {
                        particle[i].X = particle[i].X - 2;
                    }
                    prob = rnd.NextDouble();
                    if (prob < 0.5)
                    {
                        particle[i].Y = particle[i].Y + 2;
                    }
                    else
                    {
                        particle[i].Y = particle[i].Y - 2;
                    }
                    //apply constriant
                    if (particle[i].X < xleft)
                        particle[i].X = (int)xleft;
                    else if (particle[i].X > xright)
                        particle[i].X = (int)xright;
                    if (particle[i].Y < yup)
                        particle[i].Y = (int)yup;
                    else if (particle[i].Y > ydown)
                        particle[i].Y = (int)ydown;
                    gg.FillEllipse(sb, particle[i].X, particle[i].Y, 5, 5);
                    int xx = (int)(particle[i].X + xleft) / 20;
                    int yy= (int)(particle[i].Y + yup) / 20;
                    rho[xx, yy] = rho[xx, yy] + 1;

                }
                Graphics gg1 = this.CreateGraphics();
                SolidBrush sb2 = new SolidBrush(Color.Blue);
                double entropy = 0;
                for (int i = 0; i < (xc+xc); i++)
                {
                    for (int j = 0; j < (yc+yc); j++)
                    {
                        if (rho[i, j] != 0)
                        {
                            entropy = entropy - (rho[i, j] * Math.Log(rho[i, j]));
                        }
                    }
                }
                gg1.FillEllipse(sb2, 200 + (float)t, 10-(float)entropy, 4, 4);
                t = t + 0.2;
            }
        }

        private void entropywithclassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            int size = 100, n = 10;
            Entropy_class obj = new Entropy_class(this,f2, n, size);
            obj.drop();
            obj.dif_process();
        }
    }
}
