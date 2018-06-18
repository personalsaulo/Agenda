using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda.Model
{
    public class RepositorioDePessoas
    {
        private static List<Pessoa> listaPessoa = new List<Pessoa>();


        public void cadastraPessoa(Pessoa pessoa)
        {
            listaPessoa.Add(pessoa);
        }

        public void BuscaPessoa(string nome)
        {
            int opcao;
            for (int i = 0; i < listaPessoa.Count; i++)
            {
                if (listaPessoa[i].Nome.Contains(nome))
                {
                    Console.WriteLine(i + " - Nome Completo: " + listaPessoa[i].Nome + " " + listaPessoa[i].Sobrenome);
                }

            }
            opcao = int.Parse(Console.ReadLine());

            for (int i = 0; i < listaPessoa.Count; i++)
            {
                if (i == opcao)
                {
                   int dias =  CalculaQuantosDiasFaltamParaAniversario(listaPessoa[i].DataAniversario);
                    Console.WriteLine(i + " - Nome Completo: " + listaPessoa[i].Nome + " " + listaPessoa[i].Sobrenome + "\n" + "Faltam: " + dias + " dias para esse aniversário.");
                }
            }

        }

        private int CalculaQuantosDiasFaltamParaAniversario(DateTime dataDeAniversario)
        {
            int dias = 0;
            int diferencaDeAnos = DateTime.Now.Year - dataDeAniversario.Year;

            bool mesmoAno = DateTime.Now.Year == dataDeAniversario.AddYears(diferencaDeAnos).Year;
            bool maiorqMesAtual = DateTime.Now.Month < dataDeAniversario.Month;
            int diaDoAnoDoAniversario = dataDeAniversario.AddYears(diferencaDeAnos).DayOfYear;
            int diadoAnoAtual = DateTime.Now.DayOfYear;


            if (mesmoAno)
            {
                if (maiorqMesAtual)
                    dias = diaDoAnoDoAniversario - diadoAnoAtual;
                else
                    dias = diadoAnoAtual - diaDoAnoDoAniversario;
            }
            else
                dias = diaDoAnoDoAniversario - diadoAnoAtual;


            return dias;

            return dias;


        }
    }
}
