using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvInventarioCambioCodigo
    {
        public string TipoCp { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Sucursal { get; set; } = null!;
        public string Responsable { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string NumeroDoc { get; set; } = null!;
        public string Observacion { get; set; } = null!;
        public string? CodigoProducto { get; set; }
        public string? DescripcionProducto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Total { get; set; }
    }
}
