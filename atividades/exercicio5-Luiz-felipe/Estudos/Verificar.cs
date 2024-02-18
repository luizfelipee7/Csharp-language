using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeros
{
    internal class Verificar
    {
        public virtual void numero(int num)
        {
            Console.WriteLine("numero");

        }
    }
        internal class Verificarpositivo : Verificar
        {
            public override void numero(int num)
            {
                if (num > 0)
                {
                    Console.WriteLine("numero positivo");
                }

            }
        }
        internal class Verificarnegativo : Verificar
        {
            public override void numero(int num)
            {
                if (num < 0)
                {
                    Console.WriteLine("numero negativo");
                }

            }
        }
        internal class Verificarneutro : Verificar
        {
            public override void numero(int num)
            {
                if (num == 0)
                {
                    Console.WriteLine("numero neutro");
                }

            }
        }


    
}
