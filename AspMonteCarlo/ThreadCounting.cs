using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using System.Threading.Tasks;

namespace AspMonteCarlo
{
    class ThreadCounting
    {
        public double _od { get; set; }
        public double _do { get; set; }
        public int _wan { get; set; }
        public int _iter { get; set; }

        private double[] nacz;
        private double[] kon;

        public ThreadCounting(double od, double doo, int wan, int iter)
        {
           
            this._od = od;
            this._do = doo;
            this._wan = wan;
            this._iter = iter;
        }

        private void insertInTables()
        {
            nacz = new double[this._wan];
            kon = new double[this._wan];

            double krok = Math.Abs(this._do - this._od) / this._wan;

            nacz[0] = this._od;
            kon[0] = nacz[0] + krok;

            for (int q = 1; q < nacz.Length; q++)
            {
                nacz[q] = nacz[q - 1] + krok;
                kon[q] = kon[q - 1] + krok;

            }

        }



        public double obliczMC()
        {

            insertInTables();

            MonteCarlo[] mcTab = new MonteCarlo[this._wan];
            for (int i = 0; i < mcTab.Length; i++)
            {
                mcTab[i] = new MonteCarlo(this.nacz[i], this.kon[i], this._iter);
            }

            Thread[] dataItems = new Thread[this._wan];
            double[] wyniki = new double[this._wan];

            for (int j = 0; j < dataItems.Length; j++)
            {

                int lokal = j;
                dataItems[lokal] = new Thread(() =>
                {
                    wyniki[lokal] = mcTab[lokal].licz();
                });

            
                dataItems[lokal].Start();

            }


            int k;
            double wynik_kon = 0;
            for (k = 0; k < this._wan; k++)
            {
                dataItems[k].Join();
                wynik_kon += wyniki[k];

            }

            return wynik_kon;
        }
    }
}