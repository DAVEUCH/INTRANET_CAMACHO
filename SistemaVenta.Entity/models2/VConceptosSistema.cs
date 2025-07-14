using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VConceptosSistema
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string TipoCpAsociado { get; set; } = null!;
        public string OrigenDestino { get; set; } = null!;
        public int Sistema { get; set; }
        public bool TieneCpInventario { get; set; }
        public bool TieneCpCaja { get; set; }
        public bool TieneCpCobrarPagar { get; set; }
        public bool TieneCpOrigen { get; set; }
        public bool Contabilizable { get; set; }
        public bool Activo { get; set; }
        public string CreadoPartirDe { get; set; } = null!;
        public string? Detalle { get; set; }
        public string VoucherContable { get; set; } = null!;
        public string RedondeoCargo { get; set; } = null!;
        public string RedondeoAbono { get; set; } = null!;
        public string AuxiliarRedondeo { get; set; } = null!;
        public bool TipoCambioEnComprobante { get; set; }
        public string RutaTipoCambio { get; set; } = null!;
    }
}
