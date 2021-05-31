﻿using CursoCSharp.ClassesEMetados;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetados
{
    class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;

            return this;
        }

        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }
        
        public int Resultado()
        {
            return memoria;
        }

        }
    }


    class CalculadoComun
    {
        public int Somar(int a , int b)
        {
            return a + b;
        }
    
        public int Subtrair(int a , int b)
        {
            return a - b;
        }


        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Divisao(int a, int b)
        {
            return a / b;
        }
    }

    class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadoraComun = new CalculadoComun();

           var  resultado = calculadoraComun.Somar(2, 5);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComun.Subtrair(8,5));
            Console.WriteLine(calculadoraComun.Multiplicar(5,2));
            Console.WriteLine(calculadoraComun.Divisao(30,3));

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir()
                .Limpar().Imprimir();

     
        }
    }

