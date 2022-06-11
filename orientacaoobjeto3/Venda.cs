using System;
using System.Collections.Generic;
using System.Text;

namespace orientacaoobjeto3
{
    public class Venda
    {
        public double Valortotaldavenda { get; set; }
        public Vendedor Vendedor { get; set; }
        public Cliente Cliente { get; set; }
        public Venda(double ValorTotal, Cliente cliente, Vendedor vendedor)
        {
        }
        


    public Venda(double valortotal, Vendedor vendedor, Cliente cliente)
        {
            this.Valortotaldavenda = valortotal;
            this.Vendedor = vendedor;
            this.Cliente = cliente;
        }



    }
    
}
