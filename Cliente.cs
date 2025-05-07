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
        private int idade;
        public int Idade
        {
            get { return idade; }
            set
            {

                if (value > 0)
                {
                    idade = value;
                }
                else
                {
                    idade = 0;
                }

            }
        }
        public bool Prioridade { get; set; }
        
       


        public void Cadastrar()
        {
            string prioritario;
            Console.WriteLine("Digite o nome");
            Nome = Console.ReadLine();
            Nome = Nome.ToUpper();
            Console.WriteLine("Digite sua idade");
            Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Prioritário[s/n]");
            prioritario = Console.ReadLine();
            prioritario = prioritario.ToUpper();
            Console.Clear();

            if (prioritario == "S" || Idade >= 60)
            {
                Prioridade = true;
            }
            else
            {
                Prioridade = false;
            }

            

    

        }



    }
}
