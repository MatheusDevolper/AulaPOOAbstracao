using System;
using AulaPOO_Abstracao.classes;

namespace AulaPOO_Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor à ser pago:");
            float valorTotal = float.Parse(Console.ReadLine());

            
            string menu;
            do
            {
                System.Console.WriteLine("\nEscolha um método de pagamento");
                System.Console.WriteLine("[ 1 ] Boleto (desconto de 12%)");
                System.Console.WriteLine("[ 2 ] Cartão de Crédito");
                System.Console.WriteLine("[ 3 ] Cartão de Débito");
                System.Console.WriteLine("[ 4 ] Cancelar");
                System.Console.WriteLine("[ 0 ] Sair");
                menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                       
                        Boleto boleto = new Boleto();
                        boleto.Valor = valorTotal;
                        Console.Clear();
                        boleto.Registrar(boleto.Valor, boleto.Data, boleto.CodigoBarras);
                        break;
                    case "2":

                        
                        Credito credito = new Credito();

                        Console.Clear();
                        System.Console.WriteLine("Condições de Parcelamento:\n");
                        System.Console.WriteLine("Nas compras parceladas em até 6 vezes terão taxas de juros de 5%\nNas compras parceladas de 7 à 12 vezes terão taxas de juros de 8%");
                        System.Console.WriteLine("\nNão é possível parcelar uma compra mais do que 12 vezes");
                        System.Console.WriteLine("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");

                        credito.Valor = valorTotal;
                        System.Console.WriteLine("Digite abaixo a quantidade de parcelas:");
                        int parcelas = int.Parse(Console.ReadLine());
                        
                         if(parcelas >12)
                        {
                            System.Console.WriteLine("Não é possível parcelar mais que 12 vezes.");
                            break;
                        }
                        if (parcelas <= 6)
                        {
                            System.Console.WriteLine($"Valor a ser pago com taxa aplicada {credito.Valor+(credito.Valor*0.05)}");
                        }
                        else
                        {
                            System.Console.WriteLine($"Valor a ser pago com taxa aplicada {credito.Valor+(credito.Valor*0.08)}");
                        }
                                                

                        credito.Pagar(valorTotal);

                        break;
                    case "3":
                       
                        Console.Clear();
                        Debito debito = new Debito();
                        debito.Valor = valorTotal;
                        System.Console.WriteLine($"Valor à ser pago {debito.Valor}");
                        debito.Pagar(valorTotal);
                        break;

                    case "4":
                       
                        Console.Clear();
                        Debito cancelar = new Debito();
                        System.Console.WriteLine(cancelar.Cancelar());

                        break;                        
                    default:
                        // System.Console.WriteLine("Opção Inválida!");
                        break;
                }

            } while (menu != "0");
            
            Console.Clear();
            System.Console.WriteLine("Obrigado, volte Sempre!");
            
        }
    }
}
