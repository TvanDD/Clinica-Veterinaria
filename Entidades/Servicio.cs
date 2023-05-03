using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Servicio
    {
        public Servicio()
        {
            
        }

        public string IdServicio { get; set; }
        public string Tiposervicio { get; set; }
        public float Precioservicio { get; set; }
        public float Preciototal { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
