using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetados
{
    class GetSet
    {
        class moto
        {
            private String Marca;
            private String Modelo;
            private int Cilindrada;

            public moto (String marca,String modelo,int cilindrada)
            {
              SetMarca(marca);
              SetModelo(modelo);
              SetCilindrada(cilindrada);
            }

            public moto()
            {

            }
            // Método GET
            public String GetMarca() {
                return Marca;
            }

            public String GetModelo()
            {
                return Modelo;
            }

            public int GetCilindrada()
            {
                return Cilindrada;
            } 
            //Método SET

            public void SetMarca(String marca)
            {
                Marca = marca;
            }

            public void SetModelo(String modelo)
            {
                Modelo = modelo;
            }

            public void SetCilindrada(int cilindrada)
            {
                if(cilindrada > 0)
                    Cilindrada = cilindrada;
            }
            
            
            //public string marca { get; set; }

            //public string modelo { get; set; }

            //public int cilindrada { get; set; }
        }
        public static void Executar()
        {
            var moto1 = new moto("kavasaki", "rtx", 1000);

            Console.WriteLine("sua marca é :" + moto1.GetMarca());
            Console.WriteLine("Modelo da moto é :" + moto1.GetModelo());
            Console.WriteLine("sua cilindrada é: " + moto1.GetCilindrada());


            moto1.SetMarca("yamaha");
            moto1.SetModelo("kfx 2800");
            moto1.SetCilindrada(1000);

            Console.WriteLine("---------imprimindo variaveis atualizadas------------");

            Console.WriteLine("sua marca é :" + moto1.GetMarca());
            Console.WriteLine("Modelo da moto é :" + moto1.GetModelo());
            Console.WriteLine("sua cilindrada é: " + moto1.GetCilindrada());
        }
    }
}
