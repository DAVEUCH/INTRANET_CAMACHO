using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VObtenerVoucherModificado
    {
        public string? NumCp { get; set; }
        public string? TipoCp { get; set; }
        public string NumVoucher { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Periodo { get; set; } = null!;
        public int IdenvioLibroElectronico { get; set; }
    }
}
