using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Exececoes;
using CursoCSharp.TopicosAvancados;
using CursoCSharp.API;

namespace CursoCSharp
{
    class Programa
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>()
            {
                //Fundamentos
                {"Primeiro Program - Fundamentos", PrimeiroPrograma.Executar },
                {"Cometários - Fundamentos", Comentarios.Executar },
                {"Váriaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Inferencia - Fundamentos", Inferencia.Executar },
                {"Interpolação - Fundamentos", Interpolacao.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos", LendoDados.Executar },
                {"Formatando Numero - Fundamentos", FormatandoNumero.Executar },
                {"Conversoes - Fundamentos", Conversoes.Executar },
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar },
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores Logicos - Fundamentos", OperadorsLogicos.Executar },
                {"Operadores de Atribuição - Fundamentos", OperadoresDeAtribuicao.Executar },
                {"Opreadores Unarios - Fundamentos", OperadoresUnarios.Executar },
                {"Operador Ternario - Fundamentos", OperadorTernario.Executar },
                // Estruturas de Controle
                {"estrutur if - Estruturas de Controle", EstruturaIF.Executar },
                {"Estrutura if Else - Estruturas de Controle", EstruturaifElse.Executar },
                {"Estrutura if Else if - Estruturas de Controle", EstruturaifElseIf.Executar },
                {"Estrutura SWITCH - Estruturas de Controle", EstruturaSwitch.Executar },
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar },
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar },
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar },
                {"Estrutura Foreach - Estruturas de Controle", EstruturaForeach.Executar },
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar },
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar },
                // Classes E Métodos
                {"Classes vs Objetos - Classes e Métodos", ClassesVsObjetos.Executar},
                {"Métodos - Classes e Métodos", Metodos.Executar },
                {"Membros Atributos Métodos - Classes e Métodos", Membros.Executar },
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estaticos - Classes e Métodos", MetodosEstatico.Executar},
                {"Atributs Estaticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio e Atributo - Classes e Métodos", DesafioAtributo.Executar},
                {"Params - Classes e Métodos", Params.Executar },
                {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"GET AND SET - Classes e Métodos", Getters_and_Setters.Execute },
                {"Props - Classes e Métodos",Props.Executar},
                {"Readonly - Classes e Métodos",Readonly.Executar},
                {"Exemplo Enum - Classes e Métodos",ExemploEnum.Executar },
                {"Struct - Classes e Métodos",Struct.Executar },
                {"Struct vs Classes - Classes e Métodos",StructVsClasses.Executar},
                {"Valor vs Referencia - Classes e Métodos",ValorVsReferencia.Executar},
                {"Parametros por Referencia - Classes e Métodos",ParametrosPorReferencia.Executar},
                {"Parametros Padrões - Classes e Métodos",ParametroPadrao.Executar},
                //Coleçoes
                {"Array - Coleçoes",Colecoes.Array.Executar },
                {"Colecoes e list - Colecoes",ColecoesList.Executar},
                {"Colecoes Array List - Colecoes",ColecoesArrayList.Executar},
                {"Colecoes e Set - Colecoes",ColecoesSet.Executar},
                {"Colecoes Queue - Colecoes",ColecoesQueue.Executar},
                {"Colecoes Igualdades - Colecoes",Igualdade.Executar},
                {"Colecoes Stack - Colecoes",ColecaoStack.Executar },
                {"Colecoes Dictionary - Colecoes",ColecoesDictionary.Executar},

                //OO
                {"Heranca - OO",Heranca.Executar},
                {"Construtor This - OO",ConstrutorThis.Executar},
                {"Encapsulamento - OO",OO.Encapsulamento.Executar},
                {"Polimorfismo - OO",OO.Polimorfiso.Executar },
                {"Abstract - OO",OO.Abstract.Executar},
                {"Interface - OO",OO.Interface.Executar},
                {"Sealed - OO",OO.Sealed.Executar},

                //Metodos e Funcoes
                {"Exemplo Lambda - Metodos e Funcoes",ExemploLambda.Executar},
                {"Lambda Delegate - Metodos e Funcoes",LambdasDelegate.Executar},
                {"Usando Delegate - Metodos e Funcoes",UsandoDelegate.Executar },
                {"Delegate Funcao Anonima - Metodos e Funcoes",DelegateFunAnonima.Executar},
                {"Delegates Como Parametros - Metodos e Funcoes",DelegateComeParametros.Executar},
                {"Metodos de Extensão -Metodos e Funcoes",MetodosDeExtensao.Executar},

                //Excecoes
                {"Primeira Excecoes - Excecoes ",PrimeiraExcecao.Executar },
                {"Excecoes Personalizada - Excecoes",ExcecoesPersonalizadas.Executar},

                //Topicos Avancados
                {"Linq 1 - Topicos Avancados",LINQ1.Executar },
                {"linq 2 - Topicos Avancados",LINQ2.Executar },
                {"Nullables - Topicos Avancados",TopicosAvancados.Nullables.Executar},
                {"Dynamics - Topicos Avancados",TopicosAvancados.Dynamics.Execute },
                {"Genericos - Topicos Avancados",Genericos.Executar },

                //API
                {"Primeiro Arquivo - Usando API",PrimeiroArquivo.Executar},
                {"Lendo Arquivos - Usando API",LendoArquivos.Executar},
                {"Exemple FileInfo - Usando API",ExemploFileInfo.Executar},
                {"Diretorios - Usando API",Diretorios.Executar},
                {"Exemplo DirectoryInfo",ExempleDirectoryInfo.Executar},
                {"Exemplo Path - Usando API",ExemploPath.Executar},
                {"Exemplo Date Time - Usando API",ExemploDateTime.Executar},
                {"Exemplo Time Span - Usando API",ExemploTimeSpan.Executar},
            });
            central.SelecionarEExecutar();
        }
    }
}