using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S4
{
    public class Refrigerante : Bebida
    {
        public bool Vidro { get; set; }

        public Refrigerante(bool vidro, int id, string tipo, decimal miliLitro, string nomeBebida, decimal valorCompra) : base (id, tipo, miliLitro, nomeBebida, valorCompra)
        {
            Vidro = vidro;
        }

        public void ImprimirDados()
        {
            {
                if (Vidro == true)
                {
                    Console.WriteLine($"O produto id {Id} com nome {NomeBebida} é um refrigerante MiliLitros {MiliLitro} é um vidro", this.Id, this.NomeBebida, this.MiliLitro);
                }
                if (Vidro == false)
                {
                    Console.WriteLine($"O produto id {Id} com nome {NomeBebida} é um refrigerante MiliLitros {MiliLitro} é uma garrafa pet", this.Id, this.NomeBebida, this.MiliLitro);
                }
            }
        }
    }
}
