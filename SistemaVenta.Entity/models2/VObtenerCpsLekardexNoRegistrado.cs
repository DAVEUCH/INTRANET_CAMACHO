using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VObtenerCpsLekardexNoRegistrado
    {
        public int IdvoucherContableResumen { get; set; }
        public string NumCp { get; set; } = null!;
        public string? TipoCp { get; set; }
        public string NumVoucher { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Periodo { get; set; } = null!;
        public int Idfiltro { get; set; }
        public int Idejercicio { get; set; }
        public string Mes { get; set; } = null!;
        public bool? Nuevo { get; set; }
        public int? Pkid { get; set; }
    }
}
