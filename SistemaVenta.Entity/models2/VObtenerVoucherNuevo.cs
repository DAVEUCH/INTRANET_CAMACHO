using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VObtenerVoucherNuevo
    {
        public int IdvoucherContableResumen { get; set; }
        public string? NumCp { get; set; }
        public string? TipoCp { get; set; }
        public string? NumVoucher { get; set; }
        public DateTime? Fecha { get; set; }
        public string Periodo { get; set; } = null!;
        public int Idfiltro { get; set; }
        public bool? Nuevo { get; set; }
        public int? Idperiodo { get; set; }
    }
}
