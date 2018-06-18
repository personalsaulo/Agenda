using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda
{
    public class Pessoa
    {
        
        public DateTime DataAniversario { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        List<Pessoa> listaPessoa = new List<Pessoa>();

        public void cadastraPessoa(Pessoa pessoa)
        {
            listaPessoa.Add(pessoa);
        }

        public void BuscaPessoa(string nome)
        {
            for(int i=0; i < listaPessoa.Count; i++)
            {
                if (listaPessoa[i].Nome.Contains(nome))
                {
                    Console.WriteLine(" Nome: " + listaPessoa[i].Nome + " Sobrenome: " + listaPessoa[i].Sobrenome + "  Data de Aniversário: : " + listaPessoa[i].DataAniversario);
                }

            }
        }
    }
}
