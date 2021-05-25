using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentário - fundamentos", Comentarios.Executar },
                {"Variaveis e Constante - fundamentos", VariaveisEConstantes.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}