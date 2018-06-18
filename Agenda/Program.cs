using System;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            Pessoa pessoa = new Pessoa();
            do
            {
                Console.WriteLine("Agenda");
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Pesquisar");
                Console.WriteLine("3 - Sair");

                opcao = int.Parse(Console.ReadLine());


                if (opcao == 1)
                {
                    Console.WriteLine("Cadastrando....: ");
                    Console.WriteLine("Nome: ");
                    pessoa.Nome = Console.ReadLine();
                    Console.WriteLine("Sobrenome: ");
                    pessoa.Sobrenome = Console.ReadLine();
                    Console.WriteLine("Data De Aniversário: ");
                    pessoa.DataAniversario = DateTime.Parse(Console.ReadLine());

                    pessoa.cadastraPessoa(pessoa);
                }

                if (opcao == 2)
                {
                    Console.WriteLine("Pesquisando.... ");
                    Console.WriteLine("Nome: ");
                    string nome = Console.ReadLine();

                    pessoa.BuscaPessoa(nome);
                }
                    


            } while (opcao != 3 );

            Console.ReadKey();

        }
    }
}
