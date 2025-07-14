using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EAsiento
    {
        public int Idvoucher { get; set; }
        public int AsientosId { get; set; }
        public string AsientosGlosa { get; set; } = null!;
        public decimal AsientosTotalCargo { get; set; }
        public decimal AsientosTotalAbono { get; set; }
        public bool AsientosEsTransferencia { get; set; }
        public decimal AsientosTotalCargoMonedaBase { get; set; }
        public decimal AsientosTotalAbonoMonedaBase { get; set; }
        public decimal AsientosCuadre { get; set; }
        public bool AsientosResumirEnLibroDiario { get; set; }
        public int AsientosIdlibroAuxiliar { get; set; }
    }
}
