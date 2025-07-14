using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvInformacionDocumentoCargoyAbonoVenta
    {
        public int DocumentoId { get; set; }
        public int DocCargoId { get; set; }
        public string Proveedor { get; set; } = null!;
        public string Rucproveedor { get; set; } = null!;
        public int Idproveedor { get; set; }
        public string TipoDoc { get; set; } = null!;
        public string NumeroDoc { get; set; } = null!;
        public DateTime FechaDoc { get; set; }
        public DateTime FechaVceDoc { get; set; }
        public decimal TotalDoc { get; set; }
        public int DocAbonoId { get; set; }
        public string TipoDocAbono { get; set; } = null!;
        public string DocAbonoNumero { get; set; } = null!;
        public DateTime DocAbonoFecha { get; set; }
        public string MedioPago { get; set; } = null!;
        public string NumeroBanco { get; set; } = null!;
        public string BcoCaja { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public decimal ItemPagoPago { get; set; }
    }
}
