using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VConsultaCostoPorUnidad
    {
        public int Idunidad { get; set; }
        public decimal? CostoPromedioSoles { get; set; }
        public decimal? CostoPromedioDolares { get; set; }
        public decimal? CostoUltimaCompraSoles { get; set; }
        public decimal? CostoUltimaCompraDolares { get; set; }
    }
}
