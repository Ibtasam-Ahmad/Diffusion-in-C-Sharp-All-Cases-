using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace diffusion
{
    class dif_class_dire
    {
        double xc, yc, xmin, xmax, xleft, xright, yup, ydown, ymin, ymax, prob;
        int n;
        double px, py;
        Form1 f1;
        private Point[] particle;
        Random rnd = new Random();
         public dif_class_dire(Form1 f, int inc,int n)
        {
            f1 = f;
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
             Graphics gg = f1.cube.CreateGraphics();
             SolidBrush sb = new SolidBrush(Color.White);
             SolidBrush sb1 = new SolidBrush(Color.Black);
             for (int i = 0; i < n; i++)
             {
                 prob = rnd.NextDouble();
                 px = xmin + (xmax - xmin) * prob;
                 prob = rnd.NextDouble();
                 py = ymin + (ymax - ymin) * prob;
                 particle[i].X = (int)px;
                 particle[i].Y = (int)py;
                 gg.FillEllipse(sb, particle[i].X, particle[i].Y, 5, 5);

             }
         }
         public void dif_process()
         {
             Graphics gg = f1.cube.CreateGraphics();
             SolidBrush sb = new SolidBrush(Color.White);
             SolidBrush sb1 = new SolidBrush(Color.Black);
             while (true)
             {
                 Thread.Sleep(100);
                 for (int i = 0; i < n; i++)
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
    }
}
