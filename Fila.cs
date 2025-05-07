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
        public int qtdProprietario;

        public void Atender()
        {
            
            Console.Clear();
            if (qtd < 1)
            {
                Console.WriteLine("\nNão há ninguém para Atender");
            }
            else
            {
                Cliente atendido = fila[0];
                Console.WriteLine("Atendendo: {0}", atendido.Nome);

                for (int i = 0; i < qtd - 1; i++)
                {
                    fila[i] = fila[i + 1];
                }

                fila[qtd + 1] = null;
                qtd--;
            }
        }


        public void adicionarFila()
        {
            if (qtd >= 10)
            {
                Console.WriteLine("Fila Cheia");
            }
            else
            {
                Cliente paciente = new Cliente();
                paciente.Cadastrar();

                if (paciente.Prioridade)
                {
                    qtdProprietario++;
                    for (int i = qtd; i > 0; i--)
                    {
                        
                        fila[i] = fila[i - 1];
                        
                    }
                    fila[0] = paciente;
                    Console.WriteLine("Cadastrado como Prioridade");
                    
                    

                }
                else
                {

                    fila[qtd] = paciente;
                    Console.WriteLine("Cadastrado");
                }

                qtd++;
            }
            
        }

        public void Listar()
        {
            
            if (fila[0] == null)
            {
                Console.WriteLine("Fila Vazia");
            } else {
                for (int i = 0; i < qtd; i++)
                {
                    Cliente pacienteAtual = fila[i];


                    if (pacienteAtual.Prioridade)
                    {
                        Console.WriteLine("{0}. {1}, {2} | Prioritário: Sim", i+1, pacienteAtual.Nome, pacienteAtual.Idade);
                    }
                    else
                    {
                        Console.WriteLine("{0}. {1}, {2} | Prioritário: Não", i+1, pacienteAtual.Nome, pacienteAtual.Idade);
                    }

                }
                    
            }

        }


     



    }
}
