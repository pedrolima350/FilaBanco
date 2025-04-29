using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaBanco
{
    internal class Fila
    {
        public Cliente[] fila = new Cliente[10];
        public int qtd = 0;



        public void adicionarFila()
        {
           if (qtd < 10 || qtd > 0)
            {
                Cliente paciente = new Cliente();
                paciente.Cadastrar();
                fila[qtd] = paciente;

            } else if (qtd > 10) {
                Console.WriteLine("Fila Cheia");

            } else {
                Console.WriteLine("Inválido");
            }

            qtd++;
            
        }

        public void Listar()
        {
            Console.WriteLine("\nFILA DE ATENDIMENTO:");
            for (int i = 0; i < qtd; i++)
            {
                Cliente pacienteAtual = fila[i];

                if(pacienteAtual.Idade >= 60)
                {
                    pacienteAtual.Prioridade = "Sim";
                }
                else
                {
                    pacienteAtual.Prioridade = "Não";
                }

                    Console.WriteLine("{0}, {1} | Prioritário: {2}", pacienteAtual.Nome, pacienteAtual.Idade, pacienteAtual.Prioridade);
            }

        }


     



    }
}
