using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Direccion
    {
        public Direccion()
        {
            DireccionZonas = new HashSet<DireccionZona>();
        }

        public int Pkid { get; set; }
        public int Iddistrito { get; set; }
        public int Idprovincia { get; set; }
        public int Iddepartamento { get; set; }
        public int Idpersona { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool DireccionPrincipal { get; set; }
        public string Sucursal { get; set; } = null!;

        public virtual Departamento IddepartamentoNavigation { get; set; } = null!;
        public virtual Distrito IddistritoNavigation { get; set; } = null!;
        public virtual Persona IdpersonaNavigation { get; set; } = null!;
        public virtual Provincium IdprovinciaNavigation { get; set; } = null!;
        public virtual DireccionCliente DireccionCliente { get; set; } = null!;
        public virtual ICollection<DireccionZona> DireccionZonas { get; set; }
    }
}
