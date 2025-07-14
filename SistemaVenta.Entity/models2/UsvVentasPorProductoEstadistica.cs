using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVentasPorProductoEstadistica
    {
        public int Idventa { get; set; }
        public string? TipoCp { get; set; }
        public string? CodigoTipoCp { get; set; }
        public string NumCp { get; set; } = null!;
        public int Idperiodo { get; set; }
        public DateTime Fecha { get; set; }
        public string? Año { get; set; }
        public string? Mes { get; set; }
        public int? MarcaId { get; set; }
        public string? MarcaCodigo { get; set; }
        public string? MarcaDescripcion { get; set; }
        public int? ClienteId { get; set; }
        public int? ProductoId { get; set; }
        public string? ProductoCodigo { get; set; }
        public int? CantidadUnidadBase { get; set; }
        public decimal? ValorVentaSoles { get; set; }
        public decimal? TotalSoles { get; set; }
        public decimal? ValorVentaDolares { get; set; }
        public decimal? TotalDolares { get; set; }
        public int? NumTransacVtas { get; set; }
        public int? NumPzasXtransacVtas { get; set; }
        public int? NumProductos { get; set; }
        public int? NumClientes { get; set; }
    }
}
