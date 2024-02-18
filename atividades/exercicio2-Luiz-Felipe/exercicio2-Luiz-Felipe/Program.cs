
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2_Luiz_Felipe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Calculos calc = new Calculos();
           
         

            Console.WriteLine("Digite o valor do 1 item: ");
            int item1 = int.Parse(Console.ReadLine());

             Console.WriteLine("Digite o valor do 2 item: ");
             int item2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do 3 item: ");
             int item3 = int.Parse(Console.ReadLine());

             Console.WriteLine("Digite o valor do 4 item: ");
            int item4 = int.Parse(Console.ReadLine());





            int totalS = calc.soma(item1, item2,  item3,  item4);
            int Multi5 = calc.multi5(totalS);
            int Multi20 = calc.multi20(totalS);


            float totalmult20 = Multi20;
            float Divi = calc.divi20(totalmult20);
            float Subt = calc.subt(totalS, Divi);
            float totaldisc20 = Subt;
            

            float totalmult5 = Multi5;
            Divi = calc.divi5(totalmult5);
            Subt = calc.subt(totalS, Divi);
            float totaldisc5 = Subt;

            float P2 = calc.parcela2(totalS);
            float P3 = calc.parcela3(totalS);



            Console.Clear();
            Console.WriteLine("\nO valor Total da compra foi de: R$ " + totalS + "\n");

            Console.WriteLine("Digite 1 ->  a vista ");
            Console.WriteLine("Digite 2 ->  cartão de credito ");


            Console.WriteLine("Qual a forma de pagamento ");
            int op = int.Parse(Console.ReadLine());


            switch (op)
            {
                case 1:
                    if (totalS <= 100)
                    {
                        Console.Clear();
                        Console.WriteLine("\n[A VISTA]\n");
                        Console.WriteLine("\nO valor Total da compra foi de: R$ " + totalS + "\n");
                        Console.WriteLine("\nO valor da compra com desconto de 20% ficou: R$ " + totaldisc20 + "\n");
                      

                    }
                    else if (totalS > 100 && totalS <= 500)
                    {
                        
                        Console.Clear();
                        Console.WriteLine("\n[A VISTA]\n");
                        Console.WriteLine("\nO valor Total da compra foi de: R$ " + totalS + "\n");
                        Console.WriteLine("\nO valor da compra com desconto de 5% ficou: R$ " + totaldisc5 + "\n");
                    }
                    else if (totalS > 500)
                    {
                        Console.Clear();
                        Console.WriteLine("\n[A VISTA]\n");
                        Console.WriteLine("\nO valor Total da compra foi de: R$ " + totalS + "\n");
                    }
                    break;

                case 2:
                    if (totalS >= 300)
                    {
                        Console.Clear(); 
                        Console.WriteLine("Voce deseja parcelar sua compra?");
                        Console.WriteLine("1 - SIM");
                        Console.WriteLine("2 - NAO");
                        int parcela = int.Parse(Console.ReadLine());

                        switch (parcela)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Voce deseja parcelar sua compra em quantas vezes?");
                                    int parcelaop = int.Parse(Console.ReadLine());

                                    if (parcelaop <= 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\n[CARTAO DE CREDITO]\n");
                                        Console.WriteLine("\nO valor Total da compra foi de: R$ " + totalS + "\n");
                                    }
                                    else if (parcelaop == 2)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\n[CARTAO DE CREDITO]\n");
                                        Console.WriteLine("\nO valor Total da compra foi de: R$ " + totalS + "\n");
                                        Console.WriteLine("O valor de R$ " + totalS + " parcelado em 2x ficou: R$ " + P2);
                                    }
                                    else if (parcelaop == 3)
                                    {
                                        Console.Clear();
                                        
                                        Console.WriteLine("\n[CARTAO DE CREDITO]\n");
                                        Console.WriteLine("\nO valor Total da compra foi de: R$ " + totalS + "\n");
                                        Console.WriteLine("O valor de R$ " + totalS + " parcelado em 3x ficou: R$ " + P3);
                                    }
                                    else if (parcelaop >= 4)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\n[CARTAO DE CREDITO]\n");
                                        Console.WriteLine("Desculpe, Nao temos parcela maiores do que 3x");
                                        Console.ReadLine();
                                    }
                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine("\n[CARTAO DE CREDITO]\n");
                                    Console.WriteLine("\nO valor Total da compra foi de: R$ " + totalS + "\n");
                                }
                                break;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n[CARTAO DE CREDITO]\n");
                        Console.WriteLine("\nO valor Total da compra foi de: R$ " + totalS + "\n");
                    }
                    break;

            }





        }

    }
}

