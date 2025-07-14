using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class LineaCreditoPorFuerzaVenta
    {
        public int Pkid { get; set; }
        public int Idcliente { get; set; }
        public int IdfuerzaVentas { get; set; }
        public int Idmoneda { get; set; }
        public decimal Monto { get; set; }
        public decimal BalanceSoles { get; set; }
        public decimal BalanceDolares { get; set; }
        public decimal Saldo { get; set; }
        public bool Activa { get; set; }
        public int DiasDeGracia { get; set; }
        public int MaximoCuentasPorCobrarVencidas { get; set; }
        public int IdmodalidadCredito { get; set; }

        public virtual Cliente IdclienteNavigation { get; set; } = null!;
        public virtual FuerzaVenta IdfuerzaVentasNavigation { get; set; } = null!;
        public virtual Monedum IdmonedaNavigation { get; set; } = null!;
    }
}
