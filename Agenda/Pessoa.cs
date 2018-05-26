using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda
{
    public class Pessoa
    {
        public string  Email { get; set; }
        public int Idade { get; set; }
        public string Nome { get; set; }
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
                    Console.WriteLine(" Nome: " + listaPessoa[i].Nome + " Idade: "+ listaPessoa[i].Idade + " Email: " + listaPessoa[i].Email);
                }

            }
        }
    }
}
