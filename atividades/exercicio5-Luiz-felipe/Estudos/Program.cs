using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Text;

namespace numeros
{

    
    internal class program 
    {
        static void Main(string[] args)
        {

            Verificar veri = new Verificar();
            Verificarpositivo verificarpositivo = new Verificarpositivo();
            Verificarnegativo verificarnegativo = new Verificarnegativo();
            Verificarneutro verificarneutro = new Verificarneutro();

            Console.WriteLine("Digite um numero");
            int num = int.Parse(Console.ReadLine());
            verificarpositivo.numero(num);
            verificarnegativo.numero(num);
            verificarneutro.numero(num);
        }
    }


}