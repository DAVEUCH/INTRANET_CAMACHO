using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemCpCajaPago
    {
        public int ItemsCpCajaPagoId { get; set; }
        public int IdcpCaja { get; set; }
        public int ItemsCpCajaPagoIditemCpCaja { get; set; }
        public decimal ItemsCpCajaPagoTipoCambio { get; set; }
        public decimal ItemsCpCajaPagoPago { get; set; }
        public decimal ItemsCpCajaPagoPagoPercepcion { get; set; }
    }
}
