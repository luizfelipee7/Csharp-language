using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1_Luiz_Felipe
{
    internal class Program
    {
        static void Main(string[] args)
        {



             Console.WriteLine("Digite o valor do 1 item: ");
            int item1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do 2 item: ");
            int item2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do 3 item: ");
            int item3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do 4 item: ");
            int item4 = int.Parse(Console.ReadLine());
            
            int total = item1 + item2 + item3 + item4; 
            Console.Clear();
            Console.WriteLine("\nO valor Total da compra foi de: R$ " + total + "\n");
           
            Console.WriteLine("Digite 1 ->  a vista ");
            Console.WriteLine("Digite 2 ->  cartão de credito ");
            

            Console.WriteLine("Qual a forma de pagamento ");
            int op = int.Parse(Console.ReadLine());

       
            switch (op)
            {
                case 1:
                    if (total <= 100)
                    {
                        Console.Clear();
                        int totalmult = total * 20;
                        float totaldivi = totalmult / 100;
                        float totaldisc = total - totaldivi;
                        Console.WriteLine("\n[A VISTA]\n");
                        Console.WriteLine("\nO valor Total da compra foi de: R$ " + total + "\n");
                        Console.WriteLine("\nO valor da compra com desconto de 20% ficou: R$ " + totaldisc + "\n");
                    }
                    else if (total > 100 && total <= 500)
                    {
                        Console.Clear();
                        float totalmult = total * 5;
                        float totaldivi = totalmult / 100;
                        float totaldisc = total - totaldivi;
                        Console.WriteLine("\n[A VISTA]\n");
                        Console.WriteLine("\nO valor Total da compra foi de: R$ " + total + "\n");
                        Console.WriteLine("\nO valor da compra com desconto de 5% ficou: R$ " + totaldisc + "\n");
                    }
                    else if (total > 500)
                    {
                        Console.Clear();
                        Console.WriteLine("\n[A VISTA]\n");
                        Console.WriteLine("\nO valor Total da compra foi de: R$ " + total + "\n");
                    }
                    break;

                case 2:
                    if (total >= 300)
                    {
                        Console.Clear();
                        Console.WriteLine("Voce pode parcelar em ate 3x");
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
                                            Console.WriteLine("\nO valor Total da compra foi de: R$ " + total + "\n");
                                        }
                                        else if (parcelaop == 2)
                                        {
                                            Console.Clear();
                                            float parcela2 = total / 2;
                                            Console.WriteLine("\n[CARTAO DE CREDITO]\n");
                                            Console.WriteLine("O valor de R$ " + total + " parcelado em 2x ficou: R$ " + parcela2);
                                        }
                                        else if (parcelaop == 3)
                                        {
                                            Console.Clear();
                                            float parcela2 = total / 3;
                                            Console.WriteLine("\n[CARTAO DE CREDITO]\n");
                                            Console.WriteLine("O valor de R$ " + total + " parcelado em 3x ficou: R$ " + parcela2);
                                        }
                                        else if (parcelaop >=4)
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
                                    Console.WriteLine("\nO valor Total da compra foi de: R$ " + total + "\n");
                                }
                                break;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n[CARTAO DE CREDITO]\n");
                        Console.WriteLine("\nO valor Total da compra foi de: R$ " + total + "\n");
                    }
                    break;

            }





        }

    }
}
  
    

