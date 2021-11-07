using System;

namespace AppProvaLogicProg_Exerc_03
{
    class Program
    {
        public static double PrecoProduto(int codigoProduto)
        {
            double valorProduto;
            listaProdutos produto = (listaProdutos)codigoProduto;

            switch (produto)
            {
                case listaProdutos.CachorroQuente:
                    valorProduto = 4.00;
                    break;
                case listaProdutos.X_salada:
                    valorProduto = 4.50;
                    break;
                case listaProdutos.X_bacon:
                    valorProduto = 5.00;
                    break;
                case listaProdutos.TorradaSimples:
                    valorProduto = 2.00;
                    break;
                case listaProdutos.Refrigerante:
                    valorProduto = 1.00;
                    break;
                default:
                    valorProduto = 0.00;
                    break;
            }
            return valorProduto;
        }

        static void Main(string[] args)
        {
            int codigo;
            int qtd;
            
            double PrecoUnidadeProduto;
            double TotalConta;

            Console.WriteLine("Informe o codigo do produto.");
            codigo = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe a quantidade consumida.");
            qtd = int.Parse(Console.ReadLine());
            
            PrecoUnidadeProduto= PrecoProduto(codigo);
            TotalConta = PrecoUnidadeProduto * qtd;

            Console.WriteLine($"Valor a patar: {TotalConta:00.00}");
            Console.ReadLine();
        }
    }
}
