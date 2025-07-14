using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoCpInventarioDireccionTransporte
    {
        public int IdproveedorTransporte { get; set; }
        public string CodigoProveedorTransporte { get; set; } = null!;
        public string NombreProveedorTransporte { get; set; } = null!;
        public string DirecciónPrincipalDestinatario { get; set; } = null!;
        public string Distrito { get; set; } = null!;
        public string Provincia { get; set; } = null!;
        public string Departamento { get; set; } = null!;
        public bool DireccionPrincipal { get; set; }
    }
}
