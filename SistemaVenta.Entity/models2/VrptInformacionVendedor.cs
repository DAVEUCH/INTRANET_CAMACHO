using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptInformacionVendedor
    {
        public string VendedorCodigo { get; set; } = null!;
        public string VendedorNombre { get; set; } = null!;
        public string? VendedorDocIdentidad { get; set; }
        public string? VendedorGrupoVentaCodigo { get; set; }
        public string? VendedorGrupoVentaNombre { get; set; }
        public string? VendedorFuerzaVentaCodigo { get; set; }
        public string? VendedorFuerzaVentaNombre { get; set; }
        public int? VendedorFuerzaVentaId { get; set; }
        public int VendedorGrupoVentaId { get; set; }
        public int VendedorId { get; set; }
    }
}
