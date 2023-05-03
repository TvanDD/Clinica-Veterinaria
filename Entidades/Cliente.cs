using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        public Cliente()
        {
            
        }
        public string IdCliente { get; set; }
        public string Nombre_clnt { get; set; } //clnt = cliente
        public string Telefono_clnt { get; set;}
        public string Cedula { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
