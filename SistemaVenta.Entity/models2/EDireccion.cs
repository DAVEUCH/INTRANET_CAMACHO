using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EDireccion
    {
        public int Id { get; set; }
        public int Iddistrito { get; set; }
        public int Idprovincia { get; set; }
        public int Idpersona { get; set; }
        public int Iddepartamento { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool DireccionPrincipal { get; set; }
        public string Sucursal { get; set; } = null!;
        public int DireccionesId { get; set; }
        public int DireccionesIddistrito { get; set; }
        public int DireccionesIdprovincia { get; set; }
        public int DireccionesIddepartamento { get; set; }
        public string DireccionesDescripcion { get; set; } = null!;
        public bool DireccionesDireccionPrincipal { get; set; }
        public string DireccionesSucursal { get; set; } = null!;
        public int DireccionesIdpersona { get; set; }
    }
}
