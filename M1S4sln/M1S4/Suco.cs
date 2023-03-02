using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S4
{
    public class Suco : Bebida
    {
        public string TipoCaixa { get; set; }

        public Suco (string tipoCaixa, int id, string tipo, decimal miliLitro, string nomeBebida, decimal valorCompra) :base (id, tipo, miliLitro, nomeBebida, valorCompra)
        {
            TipoCaixa = tipoCaixa;
        }

        public void ImprimirDados()
        {
            Console.WriteLine($"O produto id {Id} é um suco é do tipo {TipoCaixa}  com quantidade de MiliLitros {MiliLitro}", this.Id, this.MiliLitro);
        }
    }
}
