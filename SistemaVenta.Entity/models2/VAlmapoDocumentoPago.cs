using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VAlmapoDocumentoPago
    {
        public int? DocumentoPagoProveedorId { get; set; }
        public string? DocumentoPagoProveedorCodigo { get; set; }
        public string? DocumentoPagoProveedorNombre { get; set; }
        public int DocumentoPagoClienteId { get; set; }
        public string DocumentoPagoClienteCodigo { get; set; } = null!;
        public string DocumentoPagoClienteNombre { get; set; } = null!;
        public decimal DocumentoPagoSaldo { get; set; }
        public decimal? DocumentoPagoMontoSoles { get; set; }
        public decimal? DocumentoPagoMontoDolares { get; set; }
        public decimal? DocumentoPagoSaldoSoles { get; set; }
        public int DocumentoPagoSucursalId { get; set; }
        public string DocumentoPagoSucursalCodigo { get; set; } = null!;
        public string DocumentoPagoSucursalNombre { get; set; } = null!;
        public DateTime VoucherContableFecha { get; set; }
        public bool DocumentoPagoCredito { get; set; }
        public int DocumentoPagoCategoriaClienteId { get; set; }
        public string DocumentoPagoCategoriaClienteDescripcion { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public bool Tercero { get; set; }
        public string IdtipoAsociado { get; set; } = null!;
        public bool Anulado { get; set; }
        public decimal? Participacion { get; set; }
        public decimal? DocumentoPagoParticipacionSaldoSoles { get; set; }
    }
}
