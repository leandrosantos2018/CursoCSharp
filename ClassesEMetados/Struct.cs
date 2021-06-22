using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetados
{
    interface Ponto
    {
        void MoverNaDioginal(int delta);
    }
    struct Coordenada: Ponto
    {
        public int X;
        public int Y;

        public Coordenada(int x,int y)
        {
            X = x;
            Y = y;

        }

        public void MoverNaDioginal(int delta)
        {
            
        }

        public void MovernaDiogonal(int delta)
        {
            X += delta;
            Y += delta;
        }
    }
    class ExemploStruct
    {
        public static void Executar()
        {
            Coordenada coodernadaInicial;
            coodernadaInicial.X = 2;
            coodernadaInicial.Y = 2;

            Console.WriteLine("Coordanada inicial: ");
            Console.WriteLine("X = {0}",coodernadaInicial.X);
            Console.WriteLine("Y = {0}",coodernadaInicial.Y);

            var coordenadaFinal = new Coordenada(x:9,y:1);
            coordenadaFinal.MovernaDiogonal(10);
            

            Console.WriteLine("coordenada final : ");
            Console.WriteLine("X = {0}", coordenadaFinal.X);
            Console.WriteLine("Y = {0}", coordenadaFinal.Y);
        }
    }
}
