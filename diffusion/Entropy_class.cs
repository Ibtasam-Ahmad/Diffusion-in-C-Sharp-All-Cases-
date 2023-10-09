using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diffusion
{
    class Entropy_class
    {
        double xc, yc, xmin, xmax, xleft, xright, yup, ydown, ymin, ymax, prob,t=0;
        int n;
        double px, py;
        Form1 f1;
       Form2  ff;
        private Point[] particle;
        Random rnd = new Random();
         public Entropy_class(Form1 f,Form2 f2, int inc,int n)
        {
            f1 = f;
            ff=f2;
            xc = f1.cube.ClientSize.Width / 2;
            yc = f1.cube.ClientSize.Height / 2;
            xmin = xc - inc;
            xmax = xc + inc;
            ymin = yc - inc;
            ymax = yc + inc;
            xleft = xc - xc;
            xright = xc + xc;
            yup = yc - yc;
            ydown = yc + yc;
            this.n = n;
            particle = new Point[n];

        }
         public void drop()
         {
            
             for (int i = 0; i < n; i++)
             {
                 prob = rnd.NextDouble();
                 px = xmin + (xmax - xmin) * prob;
                 prob = rnd.NextDouble();
                 py = ymin + (ymax - ymin) * prob;
                 particle[i].X = (int)px;
                 particle[i].Y = (int)py;
                

             }
         }
         public void dif_process()
         {
             while (true)
             {
                 double[,] rho = new double[(int)(xc + xc), (int)(yc + yc)];
                 for (int i = 0; i < n; i++)
                 {
                   
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
                    // gg.FillEllipse(sb, particle[i].X, particle[i].Y, 5, 5);
                     int xx = (int)(particle[i].X + xleft) / 20;
                     int yy = (int)(particle[i].Y + yup) / 20;
                     rho[xx, yy] = rho[xx, yy] + 1;
                 }
                 Graphics gg1 = ff.CreateGraphics();
                 SolidBrush sb2 = new SolidBrush(Color.Blue);
                 double entropy = 0;
                 for (int i = 0; i < (xc + xc); i++)
                 {
                     for (int j = 0; j < (yc + yc); j++)
                     {
                         if (rho[i, j] != 0)
                         {
                             entropy = entropy - (rho[i, j] * Math.Log(rho[i, j]));
                         }
                     }
                 }
                 gg1.FillEllipse(sb2, 200 + (float)t, 10 - (float)entropy, 4, 4);
                 t = t + 0.2;
             }
         }
       
    }
}
