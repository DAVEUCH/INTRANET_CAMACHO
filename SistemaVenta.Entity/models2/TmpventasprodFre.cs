using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TmpventasprodFre
    {
        public int IdcptoOperacion { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Sucursal { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string? Cliente { get; set; }
        public string? RucDniCliente { get; set; }
        public string? Departamento { get; set; }
        public string? Provincia { get; set; }
        public string? Distrito { get; set; }
        public string TipoComprobante { get; set; } = null!;
        public string NroComprobante { get; set; } = null!;
        public string? Vendedor { get; set; }
        public string? CodigoProducto { get; set; }
        public string? DescripcionProducto { get; set; }
        public string? Marca { get; set; }
        public string? Linea { get; set; }
        public string? Clase { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? PrecioUnitarioSinIgvsoles { get; set; }
        public decimal TipoCambio { get; set; }
        public decimal? PrecioUnitarioSinIgvdolares { get; set; }
    }
}
