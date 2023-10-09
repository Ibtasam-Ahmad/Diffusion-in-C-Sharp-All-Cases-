using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diffusion
{
    class dif_2d
    {
        double xc, yc, xmin, xmax, xleft, xright, yup, ydown, ymin, ymax,prob;
        int n;
        double px,py;
       public Point[] particle;
        Random rnd = new Random();
        public dif_2d(double xcc, double ycc, int inc,int n)
        {
            xc = xcc;
            yc = ycc;
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
        public void drop_set( )
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
        public void dif_process(int i)
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
                 
            
        }
    }
}
