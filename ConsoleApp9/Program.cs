using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, end, s;
            int andar;
            double rg, tel;
            nome = " ";
            end = " ";
            andar = 0;
            rg = 0.0;
            tel = 0.0;
            Console.Write("Digite o nome completo do visitante: ");
            nome = Console.ReadLine();
            Console.Write("Digite o endereço do visitante: ");
            end = Console.ReadLine();
            Console.Write("Digite o andar a ser visitado: ");
            andar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o número para contato do visitante: ");
            tel = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o rg do visitante: ");
            rg = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n*****************************************************************************");
            Console.Write("\nNome: {0}", nome);
            Console.Write("\nEndereço: {0}", end);
            Console.Write("\nRG: {0}\tTelefone: {1}", rg, tel);
            Console.Write("\nAndar visitado: {0}° andar", andar);
            Console.Write("\nCadastro efetuado com sucesso!");
            Console.Write("\n*****************************************************************************");
            Console.Write("\nDeseja continuar com mais algum cadastro?\nDigite \"s\" para sim e \"n\" para não: ");
            s = Console.ReadLine();
            while (s == "s")
            {
                nome = " ";
                end = " ";
                andar = 0;
                rg = 0.0;
                tel = 0.0;
                Console.Write("Digite o nome completo do visitante: ");
                nome = Console.ReadLine();
                Console.Write("Digite o endereço do visitante: ");
                end = Console.ReadLine();
                Console.Write("Digite o andar a ser visitado: ");
                andar = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o número para contato do visitante: ");
                tel = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o rg do visitante: ");
                rg = Convert.ToDouble(Console.ReadLine());

                Console.Write("\n*****************************************************************************");
                Console.Write("\nNome: {0}", nome);
                Console.Write("\nEndereço: {0}", end);
                Console.Write("\nRG: {0}\tTelefone: {1}", rg, tel);
                Console.Write("\nAndar visitado: {0}° andar", andar);
                Console.Write("\nCadastro efetuado com sucesso!");
                Console.Write("\n*****************************************************************************");
                Console.Write("\nDeseja continuar com mais algum cadastro?\nDigite s para sim e n para não:");
                s = Console.ReadLine();
            }
        }
    }
}
