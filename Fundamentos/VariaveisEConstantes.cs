using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar() 
        {
            //area da circunferencia

            double raio = 4.5;
            const double PI = 3.14;
            raio = 5.5;
            // PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("a area é " + area);

            // Tipo interno

            bool estaChuvendo = true;
            Console.WriteLine("está chuvendo " + estaChuvendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("saldo de gol é " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("salario" + salario);

            int menorValorInteiro = int.MinValue;
            Console.WriteLine("menor int " + menorValorInteiro);

            uint populacaoBrasileira = uint.MaxValue;
            Console.WriteLine("Populacao Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("Populção Mundial " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preco do computador " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00;
            Console.WriteLine("valor Apple " + valorDeMercadoDaApple);

            decimal distaciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre estrelas " + distaciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("letra " + letra);

            String texto = "seja bem vindo ao curso c#";
            Console.WriteLine(texto);

        }
    }
}
