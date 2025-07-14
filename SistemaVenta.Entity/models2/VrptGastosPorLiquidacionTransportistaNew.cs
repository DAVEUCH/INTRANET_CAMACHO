using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptGastosPorLiquidacionTransportistaNew
    {
        public string LiquidacionNumero { get; set; } = null!;
        public DateTime LiquidacionFecha { get; set; }
        public string ComprobanteTipoCpAbreviacion { get; set; } = null!;
        public DateTime ComprobanteFecha { get; set; }
        public string ComprobanteNumCp { get; set; } = null!;
        public string ComprobanteCptoOperacion { get; set; } = null!;
        public string OrigenDestinoCodigo { get; set; } = null!;
        public string OrigenDestinoNombre { get; set; } = null!;
        public decimal? ComprobanteTotalSoles { get; set; }
        public decimal? ComprobanteTotalDolares { get; set; }
        public int Pkid { get; set; }
    }
}
