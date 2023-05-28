using System;

namespace ExemploContaPagar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Código 1: Cachorro quente - R$ 4,00");
            Console.WriteLine("Código 2: X salada - R$ 4,50");
            Console.WriteLine("Código 3: X bacon - R$ 5,00");
            Console.WriteLine("Código 4: Torrada simples - R$ 2,00");
            Console.WriteLine("Código 5: Refrigerante - R$ 1,50");
            Console.WriteLine("Digite 0 para finalizar a compra.");

            //acumular o valor total da compra conforme os itens são adicionados.
            double valorTotal = 0;

            //loop será repetido continuamente até que uma condição de interrupção seja encontrada
            while (true)
            {
                Console.Write("Digite o código do item (ou 0 para finalizar): ");
                // lê a entrada do usuário como uma string e converte essa string para um valor inteiro
                int codigo = int.Parse(Console.ReadLine());

                if (codigo == 0)
                    break;

                Console.Write("Digite a quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                double valorUnitario = 0;

                //determinar o valor unitário do item com base no código inserido pelo usuário. 
                //é útil quando há várias opções possíveis com base em um valor específico
                switch (codigo)
                {
                    case 1:
                        valorUnitario = 4.00;
                        break;
                    case 2:
                        valorUnitario = 4.50;
                        break;
                    case 3:
                        valorUnitario = 5.00;
                        break;
                    case 4:
                        valorUnitario = 2.00;
                        break;
                    case 5:
                        valorUnitario = 1.50;
                        break;
                    default:
                        Console.WriteLine("Código inválido.");
                        continue;
                }

                double valorItem = valorUnitario * quantidade;
                valorTotal += valorItem;
            }

            Console.WriteLine($"Valor total a pagar: R$ {valorTotal:F2}");
        }
    }
}


