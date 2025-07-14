using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VObtenerVouchersDesvinculado
    {
        public string? NumCp { get; set; }
        public string TipoCp { get; set; } = null!;
        public string? NumVoucher { get; set; }
        public string Periodo { get; set; } = null!;
        public int Idejercicio { get; set; }
        public string Mes { get; set; } = null!;
        public DateTime? Fecha { get; set; }
        public int IdtipoCp { get; set; }
    }
}
