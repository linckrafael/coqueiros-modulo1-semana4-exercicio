using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S4
{
    public static class Repositorio
    {
        private static List<Bebida> ListaBebida { get; set; }
        private static List<Suco> ListaSuco { get; set; }
        private static List<Refrigerante> ListaRefri { get; set; }

        static Repositorio() 
        {
            if (ListaBebida == null)
            {
                ListaBebida = new List<Bebida>();
            }

            if (ListaSuco == null)
            {
                ListaSuco = new List<Suco>();
            }

            if (ListaRefri == null)
            {
                ListaRefri = new List<Refrigerante>();
            }
        }

        public static void AdicionarSuco(Suco suco)
        {
            ListaSuco.Add(suco);
        }
        public static void AdicionarRefri(Refrigerante refrigerante)
        {
            ListaRefri.Add(refrigerante);
        }
        public static void AdicionarBebida(Bebida bebida)
        {
            ListaBebida.Add(bebida);
        }
        public static void Alterar(Bebida bebida)
        {
            foreach (var item in ListaBebida.Where(listaEmMemoria => listaEmMemoria.Id == bebida.Id))
            {
                item.Id = bebida.Id;
                item.Tipo = bebida.Tipo;
                item.MiliLitro = bebida.MiliLitro;
                item.NomeBebida = bebida.NomeBebida;
                item.ValorCompra = bebida.ValorCompra;
            }
        }

        public static void Remover(int id)
        {
            var localBebida = ListaBebida.FirstOrDefault(w => w.Id == id);
            if (localBebida != null)
            {
                ListaBebida.Remove(localBebida);
            }
        }

        public static List<Bebida> Listar()
        {
            return ListaBebida;
        }

        public static void ExecutarSuco()
        {
            foreach(var sucos in ListaSuco)
            {
                sucos.ImprimirDados();
            }
        }
        public static void ExecutarRefri()
        {
            foreach (var refris in ListaRefri)
            {
                refris.ImprimirDados();
            }
        }
    }

}
