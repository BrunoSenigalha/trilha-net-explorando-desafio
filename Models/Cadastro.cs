using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Models
{
    internal class Cadastro
    {
        private List<Pessoa> hospedes = new List<Pessoa>();
        public List<Pessoa> CadastrandoHospede()
        {
            Console.Write("Informe o nome do hóspede: ");
            string nomeHospede = Console.ReadLine();

            // Adicionando o primeiro Hóspede
            Pessoa pessoa = new Pessoa(nome: nomeHospede);
            hospedes.Add(pessoa);

            // Laço para receber mais hóspedes
            while (true)
            {
                Console.WriteLine("Gostaria de cadastrar um novo hóspede? (s/n) ");
                string opcao = Console.ReadLine().ToLower();

                if (opcao == "s")
                {
                    Console.Clear();

                    Console.Write("Informe o nome do hóspede: ");
                    nomeHospede = Console.ReadLine();

                    pessoa = new Pessoa(nome: nomeHospede);
                    hospedes.Add(pessoa);
                }
                else
                {
                    break;
                }
            }
            return hospedes;
        }

        public (string, int, decimal) CadastroSuite()
        {
            Console.Clear();

            Console.WriteLine("---ESCOLHA A SUA SUÍTE---");

            // Escolha de suíte
            Console.WriteLine(" 1 - Prime\n 2 - Standard\n 3 - Presidencial");
            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                return ("Prime", 4, 100);
            }
            else if (opcao == "2")
            {
                return ("Standard", 5, 50);
            }
            else if (opcao == "3")
            {
                return ("Presidencial", 6, 150);
            }
            else
            {
                throw new Exception("Opção incorreta!");
            }
        }
    }
}
