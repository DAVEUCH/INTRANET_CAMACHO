using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TmpgastosFre
    {
        public int Id { get; set; }
        public string NumCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public string PersonaNombre { get; set; } = null!;
        public decimal Total { get; set; }
        public string Expr1 { get; set; } = null!;
        public string EstadoEntrega { get; set; } = null!;
        public string Simbolo { get; set; } = null!;
        public string TipoCp { get; set; } = null!;
        public string EstadoDevolucion { get; set; } = null!;
        public string EstadoEntregaDevolucion { get; set; } = null!;
        public string EstadoDescuento { get; set; } = null!;
        public string Sucursal { get; set; } = null!;
        public bool Credito { get; set; }
        public string? ModalidadCredito { get; set; }
        public string NumCpContable { get; set; } = null!;
        public decimal TipoCambio { get; set; }
        public decimal Saldo { get; set; }
    }
}
