using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class MoranMovLineasCredito
    {
        public int Pkid { get; set; }
        public int? IdlineaCreditoFuerzaVentas { get; set; }
        public int? IdfuerzaVentas { get; set; }
        public int? Idcliente { get; set; }
        public decimal? Monto { get; set; }
        public DateTime? FechaOperacion { get; set; }
        public bool? TipoMov { get; set; }
        public int? IdModalidadCredito { get; set; }
        public decimal? Saldo { get; set; }
        public int? DiasdeGracia { get; set; }
        public int? MaximoCuentasVencidas { get; set; }
    }
}
