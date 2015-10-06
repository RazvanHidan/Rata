using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rata_descrescatoare
{
    [TestClass]
    public class Dobanda
    {
        [TestMethod]
        public void SumaToala()
        {
            Assert.AreEqual(total(10000, 12, 10), 10541,67);
        }
        [TestMethod]
        public void Rata()
        {
            Assert.AreEqual(rata(10000, 12, 10, 2), 909,72);
        }
        double rata(double suma, int perioada,double dobanda, int nr_luni)
        {
            double i;
            i = suma / perioada * (nr_luni -1);
            return ((suma - i) / dobanda / 12)+(suma/perioada);
        }


        double total(double suma, int perioada, double dobanda)
        {
            double suma_ramasa = suma;
            double s=0;
            int i=0;
            while (i++ < perioada)
            {
                s =s+suma_ramasa / dobanda/ 12;
                suma_ramasa = suma_ramasa - suma / perioada;
            }
            return s+suma ;
        }
    }
}
