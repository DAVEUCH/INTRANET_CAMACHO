using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvFacturaImportacionOrdImportMax
    {
        public int Pkid { get; set; }
        public string NumCp { get; set; } = null!;
        public decimal Total { get; set; }
        public string? NombreModalidadCredito { get; set; }
        public decimal Saldo { get; set; }
        public DateTime? FechaVencimiento { get; set; }
    }
}
