using Agenda.Model;
using System;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            RepositorioDePessoas repositorio = new RepositorioDePessoas();
            Pessoa pessoa = new Pessoa();
            do
            {
                Console.WriteLine("Gerenciador de Aniversarios");
                Console.WriteLine("1 - Adicionar nova pessoa");
                Console.WriteLine("2 - Pesquisar pessoas");
                Console.WriteLine("3 - Sair");

                opcao = int.Parse(Console.ReadLine());


                if (opcao == 1)
                {
                    int sair = 0;
                    Console.WriteLine("Gerenciador de Aniversarios");
                    do
                    {
                        Console.WriteLine("Digite o nome da pessoa que deseja adicionar: ");
                        pessoa.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o sobrenome da pessoa que deseja adicionar: ");
                        pessoa.Sobrenome = Console.ReadLine();
                        Console.WriteLine("Digite a data de aniversario no formato dd/MM/yyyy: ");
                        pessoa.DataAniversario = DateTime.Parse(Console.ReadLine());


                        Console.WriteLine("Os dados estão corretos ?");
                        Console.WriteLine("Nome: " + pessoa.Nome + " " + pessoa.Sobrenome);
                        Console.WriteLine("Data do aniversario: " + pessoa.DataAniversario);

                        Console.WriteLine("1 - Sim");
                        Console.WriteLine("2 - Não");
                        sair = int.Parse(Console.ReadLine());
                    } while (sair == 2);
                    
                    if(sair == 1)
                    {
                        repositorio.cadastraPessoa(pessoa);
                        Console.WriteLine("Dados adicionados com sucesso");
                    }
                    
                }

                if (opcao == 2)
                {
                    Console.WriteLine("Gerenciador de Aniversarios");
                    Console.WriteLine("Nome: ");
                    string nome = Console.ReadLine();

                    repositorio.BuscaPessoa(nome);
                }
                    


            } while (opcao != 3 );

            Console.ReadKey();

        }
    }
}
