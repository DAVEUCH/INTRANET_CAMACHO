using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ViewAlmapoCpVentum
    {
        public int? Id { get; set; }
        public string? NumCp { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? FechaEmision { get; set; }
        public decimal? Total { get; set; }
        public string Anulado { get; set; } = null!;
        public string? Nombre { get; set; }
        public string? Simbolo { get; set; }
        public string? PersonaNombre { get; set; }
        public string EstadoEntrega { get; set; } = null!;
        public string? Sucursal { get; set; }
        public string? Abreviacion { get; set; }
        public string EstadoDevolucion { get; set; } = null!;
        public string EstadoEntregaDevolucion { get; set; } = null!;
        public string EstadoDescuento { get; set; } = null!;
        public decimal? Saldo { get; set; }
        public bool? Credito { get; set; }
        public string NumeroOrdenCompra { get; set; } = null!;
        public int? IdnumCpContable { get; set; }
        public string ModalidadCredito { get; set; } = null!;
        public decimal? TipoCambio { get; set; }
        public decimal? TipoCambioCompra { get; set; }
        public decimal? TipoCambioVenta { get; set; }
        public string? VendedorCodigo { get; set; }
        public string? VendedorNombre { get; set; }
        public string DocCaja { get; set; } = null!;
        public string? Consolidado { get; set; }
    }
}
