using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamento
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentário - fundamentos", Comentarios.Executar },
                {"Variaveis e Constante - fundamentos", VariaveisEConstantes.Executar },
                {"Inferencia - fundamentos", Inferencia.Executar },
                {"Interpolacao - fundamentos", Interpolacao.Executar },
                {"Notação ponto - fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados - fundamentos", LendoDados.Executar },
                {"Formatando Numero - fundamentos", FormantandoNumero.Executar },
                {"Conversões - fundamentos", Conversoes.Executar },
                {"Operadores Aritméticos - fundamentos", OperadoresAritmeticos.Executar },
                {"Operadores Relacionais - fundamentos", OperadoresRelacionais.Executar },
                {"Operadores Logico - fundamentos", OperadoresLogicos.Executar },
                {"Operadores Atribuição - fundamentos", OperadoresAtribuicao.Executar },
                {"Operadores Unários - fundamentos", OperadoresUnarios.Executar },
                {"Operadores Ternário - fundamentos", OperadoresTernario.Executar },
                // Estrutura de Controle
                {"Estrutura If -  Estrutura de Controle", EstruturaIf.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}