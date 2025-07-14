using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemCpCajaPago
    {
        public int Pkid { get; set; }
        public int IdcpCaja { get; set; }
        public int IditemCpCaja { get; set; }
        public decimal TipoCambio { get; set; }
        public decimal Pago { get; set; }
        public decimal PagoPercepcion { get; set; }

        public virtual CpCaja IdcpCajaNavigation { get; set; } = null!;
        public virtual ItemCpCaja IditemCpCajaNavigation { get; set; } = null!;
    }
}
