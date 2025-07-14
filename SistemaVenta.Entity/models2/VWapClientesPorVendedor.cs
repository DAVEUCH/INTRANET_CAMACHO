using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VWapClientesPorVendedor
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? DocIdentidad { get; set; }
        public bool Activo { get; set; }
        public bool Descriptivo { get; set; }
        public int Idvendedor { get; set; }
        public string Direccion { get; set; } = null!;
        public int IddireccionPrincipal { get; set; }
        public int Pkidzona { get; set; }
        public int Iddireccion { get; set; }
    }
}
