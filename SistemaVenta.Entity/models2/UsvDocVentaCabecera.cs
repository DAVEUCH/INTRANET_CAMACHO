using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvDocVentaCabecera
    {
        public int FacturaId { get; set; }
        public string FacturaTdoc { get; set; } = null!;
        public string FacturaNro { get; set; } = null!;
        public string? FacturaFechaEmision { get; set; }
        public string? FacturaHoraEmision { get; set; }
        public string FacturaMoneda { get; set; } = null!;
        public decimal FacturaTotal { get; set; }
        public string? ClienteNombre { get; set; }
        public string SucursalNombre { get; set; } = null!;
        public string VendedorCodigo { get; set; } = null!;
        public string VendedorNombre { get; set; } = null!;
    }
}
