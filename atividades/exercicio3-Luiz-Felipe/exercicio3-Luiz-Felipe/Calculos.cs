using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4_Luiz_Felipe
{
    internal class Calculos : prmulti
    {
        int totalsoma;
        private int privatesoma(int item1, int item2, int item3, int item4)
        {


            totalsoma = item1 + item2 + item3 + item4;
            return totalsoma;

        }

        public int soma(int item1, int item2, int item3, int item4)
        {
            privatesoma(item1, item2, item3, item4);

            return totalsoma;
        }




        public int multi20(int totalS)
        {
        
            return prmult(totalS);

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