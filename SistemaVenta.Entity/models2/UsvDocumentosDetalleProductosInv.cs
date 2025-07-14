using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvDocumentosDetalleProductosInv
    {
        public string? CptoOperacion { get; set; }
        public string? Sucursal { get; set; }
        public string? TipoDoc { get; set; }
        public string? Moneda { get; set; }
        public decimal Total { get; set; }
        public string NumeroDoc { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public DateTime FechaEmision { get; set; }
        public string? PersonaNombre { get; set; }
        public string? Responsable { get; set; }
        public string? ProductoCodigo { get; set; }
        public string? ProductoDescripcion { get; set; }
        public string? UnidadMedida { get; set; }
        public string TipoCpInventario { get; set; } = null!;
        public decimal? Cantidad { get; set; }
        public decimal? CantidadEntrada { get; set; }
        public decimal? CantidadSalida { get; set; }
        public int? CantidadUnidadBase { get; set; }
        public decimal? ValorUnitario { get; set; }
        public decimal? TotalItem { get; set; }
        public int Idalmacen { get; set; }
        public string? Almacen { get; set; }
        public string? TipoyNroDocOrigen { get; set; }
        public string Estado { get; set; } = null!;
        public string Observacion { get; set; } = null!;
    }
}
