using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVentasPorProductoCodigo
    {
        public int? ProductoId { get; set; }
        public decimal? ValorVentaSoles { get; set; }
        public decimal? Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public int Idperiodo { get; set; }
        public int IdDocVenta { get; set; }
        public string TipoCp { get; set; } = null!;
        public string NumeroDocVta { get; set; } = null!;
        public int EsCompraCp { get; set; }
    }
}
