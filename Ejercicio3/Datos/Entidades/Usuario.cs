using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Usuario
    {
        public string Codigo { get; set; }
        public string Clave { get; set;}
        public string PrimerNombre { get; set;}
        public string PrimerApellido { get; set; }
        public string Rol { get; set; }
        public bool EstaActivo { get; set; }

        public Usuario()
        {
          
        }

        public Usuario(string codigo, string clave, string primerNombre, string primerApellido, string rol, bool estaActivo)
        {
            Codigo = codigo;
            Clave = clave;
            PrimerNombre = primerNombre;
            PrimerApellido = primerApellido;
            Rol = rol;
            EstaActivo = estaActivo;
        }
    }
}
