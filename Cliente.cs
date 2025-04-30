using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaBanco
{
    internal class Cliente
    {

        public string Nome { get; set; }
        public int Idade { get; set; }
        public bool Prioridade { get; set; } 
       


        public void Cadastrar()
        {
            Console.WriteLine("Digite o nome");
            Nome = Console.ReadLine();
            Nome = Nome.ToUpper();
            Console.WriteLine("Digite sua idade");
            Idade = int.Parse(Console.ReadLine());

            if (Idade >= 60)
            {
                Prioridade = true;
            } else {
                Prioridade = false;
            }

        }



    }
}
