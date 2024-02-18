using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4_Luiz_Felipe
{
  
    public class Parcela2
    {
        
        public virtual float parcelas2(int totalS)
        {
           

            return  totalS / 2;

           
        }
    }

    public class parcelacomMensagem : Parcela2
    {
        public override float parcelas2(int totalS)
        {
            float totalparcela;
            totalparcela = totalS / 2;
            Console.WriteLine("O valor de R$ " + totalS + " parcelado em 2x ficou: R$ " + totalparcela);
            return totalparcela;


        }
    }

    
}



