﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetados
{
    class ParamsNomeados
    {
        public static void Formatar(int dia ,int mes, int ano)
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2:D2}",dia,mes,ano);
        }

        public static void Executar()
        {
            Formatar(dia: 3,mes:6,ano: 2021);
        }
    }
}
