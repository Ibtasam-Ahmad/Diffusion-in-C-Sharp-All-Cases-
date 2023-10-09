using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diffusion
{
    class diffusion_cl
    {
        double D, dx, dt, sigma;
        int x;
        double[,] rho;
        Form1 ff;
       public diffusion_cl(Form1 f,double d1, double dxx, double dtt,int x,int size)
        {
            ff = f;
            D = d1;
            dx = dxx;
            dt = dtt;
            //sigma = sig;
            this.x = x;
            rho = new double[size, size];
        }
        public void plot()
        {
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    sigma = Math.Sqrt(2 * D * (j + 1));
                    rho[i, j] = 1 / sigma * (Math.Exp(-(x * x) / (2 * sigma * sigma)));
                }
                x++;
            }
            for (int i = 1; i < 100 - 1; i++)
            {
                for (int j = 0; j < 100 - 1; j++)
                {
                    rho[i, j + 1] = rho[i, j] + (dt / (dx * dx)) * D * (rho[i + 1, j] - 2 * rho[i, j] + rho[i - 1, j]);
                }
            }
            Graphics gg = ff.CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Purple);
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    gg.FillEllipse(sb, 200 + i * 2, 400 - (float)rho[i, j] * 1500, 5, 5);
                }
            }
        }


    }
}
