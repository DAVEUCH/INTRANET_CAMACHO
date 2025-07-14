using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VAlmapoDocumentoDeudum
    {
        public int DocumentoPagoProveedorId { get; set; }
        public string DocumentoPagoProveedorCodigo { get; set; } = null!;
        public string DocumentoPagoProveedorNombre { get; set; } = null!;
        public decimal DocumentoPagoSaldo { get; set; }
        public decimal? DocumentoPagoMontoSoles { get; set; }
        public decimal? DocumentoPagoMontoDolares { get; set; }
        public decimal? DocumentoPagoSaldoSoles { get; set; }
        public int DocumentoPagoSucursalId { get; set; }
        public string DocumentoPagoSucursalCodigo { get; set; } = null!;
        public string DocumentoPagoSucursalNombre { get; set; } = null!;
        public DateTime VoucherContableFecha { get; set; }
        public bool DocumentoPagoCredito { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public bool Tercero { get; set; }
        public string IdtipoAsociado { get; set; } = null!;
        public bool Anulado { get; set; }
    }
}
