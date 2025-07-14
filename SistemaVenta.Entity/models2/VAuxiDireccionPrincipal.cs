using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VAuxiDireccionPrincipal
    {
        public int Pkid { get; set; }
        public int Iddistrito { get; set; }
        public int Idprovincia { get; set; }
        public int Iddepartamento { get; set; }
        public int Idpersona { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool DireccionPrincipal { get; set; }
        public string Sucursal { get; set; } = null!;
    }
}
