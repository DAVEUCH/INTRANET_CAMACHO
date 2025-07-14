using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteComprasPorProveedor
    {
        public string ProveedorNombre { get; set; } = null!;
        public string? Ruc { get; set; }
        public string TipoDocumento { get; set; } = null!;
        public string ComprobanteNumCp { get; set; } = null!;
        public DateTime ComprobanteFecha { get; set; }
        public DateTime ComprobanteFechaEmision { get; set; }
        public int ComprobanteId { get; set; }
        public string NumCpContable { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Unidad { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public decimal? Cuc { get; set; }
        public decimal Total { get; set; }
    }
}
