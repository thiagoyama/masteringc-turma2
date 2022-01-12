using Fiap.Aula06.Exercicio01.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fiap.Aula06.Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criar uma lista para armazenar os alunos
            IList<Aluno> lista = new List<Aluno>();

            do
            {
                //Ler os dados do aluno (Nome, Média, Genero)
                Console.WriteLine("Digite o nome");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite a média");
                float media = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite o gênero");
                //(Genero) -> cast, forçar o objeto a ser um tipo específico
                //Enum.Parse( tipo do Enum, String para conversão, não diferencia maiúsculas e minúsculas)
                Genero genero = (Genero)Enum.Parse(typeof(Genero), Console.ReadLine(), true);

                //Instanciar um Aluno 
                var aluno = new Aluno()
                {
                    Nome = nome,
                    Media = media,
                    Genero = genero
                };

                //Adicionar na lista
                lista.Add(aluno);

                //Verificar se o usuário deseja adicionar mais alunos
                Console.WriteLine("Deseja adicionar mais um aluno? (S/N)");
            } while (Console.ReadLine().ToUpper() == "S");

            //Exibir a quantidade de alunos cadatrados (Count -> quantidade de elementos na lista)
            Console.WriteLine($"A quantidade de alunos é {lista.Count}");

            //Somar as médias de todos os alunos
            float mediaTotal = 0;
            foreach (var item in lista)
            {
                mediaTotal += item.Media;
            }

            //Exibir a média geral das notas
            Console.WriteLine($"A média geral dos alunos é {mediaTotal/lista.Count}");
            Console.WriteLine($"A média geral dos alunos é {lista.Average( a => a.Media ).ToString("n2")}");

            //Exibir a porcentagem de alunos por gênero (CTRL + D (duplica a linha))
            Console.WriteLine($"A porcentagem de alunos do gênero feminino: " +
                $"{((float) lista.Count(a => a.Genero == Genero.Feminino)/lista.Count).ToString("p")}");
            Console.WriteLine($"A porcentagem de alunos do gênero masculino: " +
                $"{((float) lista.Count(a => a.Genero == Genero.Masculino)/lista.Count).ToString("p")}");
            Console.WriteLine($"A porcentagem de alunos do gênero outros: " +
                $"{((float) lista.Count(a => a.Genero == Genero.Outros)/lista.Count).ToString("p")}");

            //Menu 1-Nome e média 2-Nome acima de 6 3-Nome por gênero 0-Sair
            int op;

            do
            {
                Console.WriteLine("Escolha: \n1-Nomes e médias \n2-Nomes acima de 6 \n3-Nome por gênero \n0-Sair");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        foreach (var item in lista)
                        {
                            Console.WriteLine($"Nome: {item.Nome}, Média: {item.Media}");
                        }
                        break;
                    case 2:
                        //Pesquisar na lista os alunos com média acima de 6 e armazena da listaFiltrada
                        var listaFiltrada = lista.Where(a => a.Media > 6).ToList();
                        foreach (var item in listaFiltrada)
                        {
                            Console.WriteLine($"Nome: {item.Nome}, Média: {item.Media}");
                        }
                        break;
                    case 3:
                        //Ler o gênero
                        Console.WriteLine("Digite o gênero");
                        Genero genero = (Genero)Enum.Parse(typeof(Genero), Console.ReadLine(), true);
                        //Filtrar a lista por gênero
                        listaFiltrada = lista.Where(a => a.Genero == genero).ToList();
                        //Exibir a lista filtrada
                        foreach (var item in listaFiltrada)
                        {
                            Console.WriteLine($"Nome: {item.Nome}, Gênero: {item.Genero}");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Finalizando o programa");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            } while (op != 0);

        }//main
    }//class
}//namespace
