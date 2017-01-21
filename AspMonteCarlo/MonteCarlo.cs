using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspMonteCarlo
{
    public class MonteCarlo
    {
        public double _od { get; set; }
        public double _do { get; set; }
        public int _iter { get; set; }

        public MonteCarlo(double od, double doo, int iter)
        {
            // TODO: Complete member initialization
            this._od = od;
            this._do = doo;
            this._iter = iter;
        }

        Random rnd = new Random();

        private double sinus(double x)
        {
            return Math.Sin(x);
        }

        private double generuj(double start, double stop)
        {
            return rnd.NextDouble() * (stop - start) + start;
        }



        public double licz(/*double oddd, double dooo*/)
        {
            //todo
            double oddd = this._od;
            double dooo = this._do;
            //


            double dx, krok, x, y, Max = 0, Min = 0;
            int N = this._iter, Npunkt = 0;
            dx = Math.Abs(dooo - oddd);
            krok = dx / 1000000;

            for (x = oddd; x <= dooo; x += krok)
            {
                if (sinus(x) >= Max) Max = sinus(x);
                if (sinus(x) <= Min) Min = sinus(x);
            }

            //Console.WriteLine(Min+" "+Max);
            double i;

            for (i = 1; i <= N; i++)
            {
                x = generuj(oddd, dooo);
                y = generuj(Min, Max);

                if ((sinus(x) >= y) && (y >= 0))
                {
                    Npunkt += 1;
                }
                else if ((sinus(x) <= y) && (y <= 0))
                {
                    Npunkt -= 1;
                }
                else
                {
                    continue;
                }
            }


            double b = Convert.ToDouble(Npunkt) / Convert.ToDouble(N);

            return b * dx * (Max - Min);
        }



    }
}