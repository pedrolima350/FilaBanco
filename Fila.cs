using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaBanco
{
    internal class Fila
    {
        public Cliente[] fila = new Cliente[10];
        public int qtd = 0;


        public void Atender()
        {
            Cliente atendido = fila[0];
            Console.WriteLine("Atendendo: {0}", atendido.Nome);

            for (int i = 0; i < qtd - 1; i++)
            {
                fila[i] = fila[i + 1];
            }

            fila[qtd - 1] = null;
            qtd--;
        }


        public void adicionarFila()
        {

                Cliente paciente = new Cliente();
                paciente.Cadastrar();

                if(paciente.Prioridade) {
                    for (int i = qtd; i > 0; i--)
                    {
                        fila[i] = fila[i - 1];
                    }
                    fila[0] = paciente;
                    Console.WriteLine("Cadastrado como Prioridade");

                } else {

                    fila[qtd] = paciente;
                    Console.WriteLine("Cadastrado");
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
                    pacienteAtual.Prioridade = true;
                }
                else
                {
                    pacienteAtual.Prioridade = false;
                }
                if(pacienteAtual.Prioridade)
                {
                    Console.WriteLine("{0}, {1} | Prioritário: Sim", pacienteAtual.Nome, pacienteAtual.Idade);
                } else
                {
                    Console.WriteLine("{0}, {1} | Prioritário: Não", pacienteAtual.Nome, pacienteAtual.Idade);
                }


                    
            }

        }


     



    }
}
