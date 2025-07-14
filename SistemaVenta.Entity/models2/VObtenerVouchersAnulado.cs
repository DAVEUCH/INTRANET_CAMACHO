using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VObtenerVouchersAnulado
    {
        public int IdvoucherContableResumen { get; set; }
        public string? NumCp { get; set; }
        public string TipoCp { get; set; } = null!;
        public string? NumVoucher { get; set; }
        public DateTime? Fecha { get; set; }
        public string Periodo { get; set; } = null!;
        public int? Idperiodo { get; set; }
        public bool? Nuevo { get; set; }
    }
}
