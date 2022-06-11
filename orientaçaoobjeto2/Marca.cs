using System;
using System.Collections.Generic;
using System.Text;

namespace orientaçaoobjeto2
{
    class Marca
    {
        public string Descriçao { get; set; }
        public string Pais  { get; set; }



     public Marca(string descriçao, string pais)
        {
            this.Descriçao = descriçao;
            this.Pais = pais;
        }
    }
}
