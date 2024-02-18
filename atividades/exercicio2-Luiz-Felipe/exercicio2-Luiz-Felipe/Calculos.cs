using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2_Luiz_Felipe
{
    internal class Calculos
    {

        public int soma(int item1, int item2, int item3, int item4)
        {
            int totalsoma;

            totalsoma = item1 + item2 + item3 + item4;

            return totalsoma;

        }
        public int multi20(int totalS)
        {

            int totalmulti20;

            totalmulti20 = totalS * 20;



            return totalmulti20;

        }
        public int multi5(int totalS)
        {

            int totalmulti5;

            totalmulti5 = totalS * 5;

            return totalmulti5;

        }
        public float divi20(float totalmult20)
        {
            float totaldivi;

            totaldivi = totalmult20 / 100;

            return totaldivi;

        }
        public float divi5(float totalmult5)
        {
            float totaldivi;

            totaldivi = totalmult5 / 100;

            return totaldivi;

        }
        public float parcela2(int totalS)
        {
            float totalparcela;

            totalparcela = totalS / 2;

            return totalparcela;

        }
        public float parcela3(int totalS)
        {
            float totalparcela;

            totalparcela = totalS / 3;

            return totalparcela;

        }
        public float subt(int totalS, float Divi)
        {
            float totalsub;

            totalsub = totalS - Divi;

            return totalsub;

        }
    }
}