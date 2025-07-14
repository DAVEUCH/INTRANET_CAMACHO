using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VMoranMovLineasCredito
    {
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int? IdlineaCreditoFuerzaVentas { get; set; }
        public int? IdfuerzaVentas { get; set; }
        public int? Idcliente { get; set; }
        public DateTime? FechaOperacion { get; set; }
        public decimal? Monto { get; set; }
        public decimal? Saldo { get; set; }
        public int? IdModalidadCredito { get; set; }
        public int? DiasdeGracia { get; set; }
        public int? MaximoCuentasVencidas { get; set; }
        public string TipoMov { get; set; } = null!;
        public string CodModalida { get; set; } = null!;
        public string FuerzaVentas { get; set; } = null!;
    }
}
