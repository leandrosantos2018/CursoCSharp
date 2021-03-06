using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetados;
using CursoCSharp.Colecoes;


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
                {"Estrutura If/Else -  Estrutura de Controle", EstruturaIfElse.Executar },
                {"Estrutura If/Else/If -  Estrutura de Controle", EstruturaIfElseIf.Executar },
                {"Estrutura switch -  Estrutura de Controle", EstruturaSwitch.Executar },
                {"Estrutura While -  Estrutura de Controle", EstruturaWhile.Executar },
                {"Estrutura Do While -  Estrutura de Controle", EstruturaDoWhile.Executar },
                {"Estrutura For -  Estrutura de Controle", EstruturaFor.Executar },
                {"Estrutura ForEach -  Estrutura de Controle", EstruturaForEach.Executar },
                {"Usando Break -  Estrutura de Controle", UsandoBreak.Executar },
                {"Usando Continue -  Estrutura de Controle", UsandoContinue.Executar },
               
                //Classes e Métodos]

                {"Membros -  Classes e Métodos", Membros.Executar },
                {"Construtores -  Classes e Métodos", Construtores.Executar },
                {"Metodos com Retorno -  Classes e Métodos", MetodosComRetorno.Executar },
                {"Metodos  Estátic -  Classes e Métodos", MetadoEstaticos.Executar },
                {"Atributos  Estátic - Classes e métodos", AtributiEstaticos.Executar },
                {"Desafio Atributos  Estátic - Classes e métodos ", DesafioAtribudo.Executar },
                {"Paramentros Varíaveis - Classes e métodos ", Params.Executar },
                {"Paramentros Nameados - Classes e métodos ", ParamsNomeados.Executar },
                {"Gets e Sets - Classes e métodos ", GetSet.Executar },
                {"Propriedade - Classes e métodos ", Props.Executar },
                {"Readonly - Classes e métodos ", Readonly.Executar },
                {"Enumeração - Classes e métodos ", ExemploEnum.Executar },
                {"Struct - Classes e métodos ", ExemploStruct.Executar },
                {"Struct Vs Classe - Classes e métodos ", StructVsClasse.Executar },
                {"Valor Vs Referencia - Classes e métodos ", ValorVsReferencia.Executar },
                {"Parâmetro Por Referencia - Classes e métodos ", ParamentroPorRefencia.Executar },
                {"Parâmetro com valor Padrão - Classes e métodos ", ParametroComValorPadrao.Executar },
                


                //Coleções
                {"Array - Coleções ", Colecoes.Array.Executar },
                {"List - Coleções ", ColecoesList.Executar },
                {"ArrayList - Coleções ", ArrayList.Executar },


            }); 
            central.SelecionarEExecutar();
        }
    }
}