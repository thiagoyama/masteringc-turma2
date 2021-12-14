using Fiap.Aula04.Exercicio03.Models;
using System;

namespace Fiap.Aula04.Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler qual formação será cadastrada
            Console.WriteLine("Digite a formação 1-Técnologo 2-Bacharelado");
            int tipo = int.Parse(Console.ReadLine());

            //Ler os dados da formação
            Console.WriteLine("Digite o nome da instituição");
            var instituicao = Console.ReadLine();

            Console.WriteLine("Digite o nome da formação");
            var nome = Console.ReadLine();

            Formacao formacao;

            if (tipo == 1)
            {
                Console.WriteLine("Plano estendido?");
                var plano = bool.Parse(Console.ReadLine());

                //Instanciar o objeto
                formacao = new Tecnologo(nome) { PlanoEstendido = plano, Instituicao = new Instituicao(instituicao) };
            }
            else
            {
                Console.WriteLine("Projeto TCC");
                var projeto = Console.ReadLine();

                Console.WriteLine("Carga horária estágio");
                var estagio = int.Parse(Console.ReadLine());

                //Instanciar o objeto
                formacao = new Bacharelado(nome, estagio) { ProjetoConclusao = projeto , Instituicao = new Instituicao(instituicao)};
            }

            //Exibir os dados
            Console.WriteLine(formacao);

            //Apresentar o menu com as opções 1-Calcular média, 2-Calcular mensalidade, 0-Sair
            int op;

            do
            {
                Console.WriteLine("Escolha 1-Calcular média, 2-Calcular  mensalidade, 0-Sair");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        //Ler as três notas
                        Console.WriteLine("Digite a nota 1");
                        int n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a nota 2");
                        int n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a nota 3");
                        int n3 = int.Parse(Console.ReadLine());
                        //Calcular e exibir a média
                        Console.WriteLine($"A média é {formacao.CalcularMedia(n1, n2, n3)}");
                        break;
                    case 2:
                        Console.WriteLine($"A mensalidade é {formacao.CalcularMensalidade()}");
                        break;
                    case 0:
                        Console.WriteLine("Finalizando o sistema");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (op != 0);
        }//main
    }//class
}//namespace
