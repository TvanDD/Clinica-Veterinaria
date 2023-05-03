using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mascota
    {
        public Mascota()
        {
            
        }
        public string IdMascota { get; set; }
        public string Nombre_mct { get; set; } //mct = mascota
       
        public string Raza { get; set;}

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
