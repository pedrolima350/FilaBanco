using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaBanco
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Fila fila = new Fila();
            string Op = "";

            fila.adicionarFila();

            do {
                

                Console.WriteLine("==========FILA=========");
                fila.Listar();

                Console.WriteLine("[a] Atender próximo Cliente");
                Console.WriteLine("[l] Listar Fila");
                Console.WriteLine("[q] Sair");
                Console.WriteLine("[c] Cadastrar");
                Op = Console.ReadLine();
                Op = Op.ToUpper();
                switch (Op)
                {

                    case "A":

                        break;
                    case "L":
                        fila.Listar();
                        break;
                    case "C":
                       fila.adicionarFila();
                        break;
                    case "Q":
                        Console.WriteLine("Fim da Execução");
                        break;
                    default:
                        Console.WriteLine("Opção não existe");
                        break;
                }


            }while (Op != "Q");


        }
    }
}
