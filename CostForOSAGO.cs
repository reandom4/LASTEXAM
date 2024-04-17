using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSAGO
{
    internal class CostForOSAGO
    {
        public int tb = 5980;
        public double kt = 1;
        public double kbm = 1;
        public double kbc = 1.6;
        public double ko = 1.3;
        public double km = 0.6;
        public double kc = 1;
        public double kn = 1.26;
        double cost;

        public void Km(int horsepowr)
        {
            if (horsepowr < 50)
            {
                km = 0.6;
            }
            if (horsepowr > 50 && horsepowr < 71)
            {
                km = 1.0;
            }
            if (horsepowr > 70 && horsepowr < 100)
            {
                km = 1.1;
            }
            if (horsepowr > 100 && horsepowr < 121)
            {
                km = 1.2;
            }
            if (horsepowr > 120 && horsepowr < 150)
            {
                km = 1.4;
            }
            if (horsepowr > 150)
            {
                km = 1.6;
            }
        }

        public void Kbm(int Driver1exp)
        {
            switch (Driver1exp)
            {
                case 0:
                    kbm = 2.45;
                    break;
                case 1:
                    kbm = 2.3;
                    break;
                case 2:
                    kbm = 1.55;
                    break;
                case 3:
                    kbm = 1.4;
                    break;
                case 4:
                    kbm = 1;
                    break;
                case 5:
                    kbm = 0.95;
                    break;
                case 6:
                    kbm = 0.9;
                    break;
                case 7:
                    kbm = 0.85;
                    break;
                case 8:
                    kbm = 0.8;
                    break;
                case 9:
                    kbm = 0.75;
                    break;
                case 10:
                    kbm = 0.7;
                    break;
                case 11:
                    kbm = 0.65;
                    break;
                case 12:
                    kbm = 0.60;
                    break;
                case 13:
                    kbm = 0.55;
                    break;
                default:
                    kbm = 0.5;
                    break;
            }
        }

        public void Kbc(int years)
        {
            if (years < 21)
            {
                kbc = 1.62;
            }
            if (years > 21 && years < 25)
            {
                kbc = 1.10;
            }
            if (years > 25 && years < 30)
            {
                kbc = 1.02;
            }
            if (years > 30 && years < 35)
            {
                kbc = 0.95;
            }
            if (years > 35 && years < 40)
            {
                kbc = 0.93;
            }
            if (years > 40 && years < 45)
            {
                kbc = 0.92;
            }
            if (years > 45 && years < 50)
            {
                kbc = 0.91;
            }
            if (years > 50 && years < 59)
            {
                kbc = 0.86;
            }
            if (years > 59)
            {
                kbc = 0.83;
            }
        }
        public double price()
        {
            cost = tb * kt * kbm * kbc * ko * km * kc; 
            return cost;
        }

    }
}
