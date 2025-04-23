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
        public string Op;



        public void opcoes()
        {
            Console.WriteLine("[a] Atender próximo Cliente");
            Console.WriteLine("[l] Listar Fila");
            Console.WriteLine("[q] Sair");
            Console.WriteLine("[c] Cadastrar");
            Op = Console.ReadLine();

            switch (Op)
            {

                
                case "a":

                break;
                case "l":

                break;
                case "c":

                break;
                case "q":

                break;

            }



        }



    }
}
