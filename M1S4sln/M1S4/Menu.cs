using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S4
{
    public static class Menu
    {
        public static int MostrarMenu()
        {
            try
            {
                Console.WriteLine("1 - Inserir Bebida");
                Console.WriteLine("2 - Alterar Bebida");
                Console.WriteLine("3 - Excluir Bebida");
                Console.WriteLine("4 - Listar todas as bebidas");
                Console.WriteLine("5 - Listar os sucos");
                Console.WriteLine("6 - Listar os refrigerantes");
                Console.WriteLine("7 - Sair");

                return int.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine("Opção com erro, selecione a correta");
            }
            return MostrarMenu();
        }
        public static bool ReiniciarDisplayConsole()
        {
            Console.WriteLine("Deseja fazer mais alguma coisa? ");
            Console.WriteLine("1 - Sim.");
            Console.WriteLine("2 - Não.");

            if (int.Parse(Console.ReadLine()) == 1)
            {
                Menu.MostrarMenu();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
