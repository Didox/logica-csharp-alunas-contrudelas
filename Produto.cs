using System;
using System.Collections.Generic;

namespace ContruDelasConsole
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }
        public List<MateriaPrima> ListaMateriaPrima { get; set; }

        public double ValorTotal()
        {
            return Valor * Quantidade;
        }
    }
}
