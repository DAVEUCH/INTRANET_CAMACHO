using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemCpCaja
    {
        public ItemCpCaja()
        {
            ItemCpCajaPagos = new HashSet<ItemCpCajaPago>();
        }

        public int Pkid { get; set; }
        public int Idmoneda { get; set; }
        public int Idpersona { get; set; }
        public decimal Amortizacion { get; set; }
        public decimal AmortizacionPercepcion { get; set; }
        public decimal PagoSoles { get; set; }
        public decimal PagoDolares { get; set; }
        public decimal TotalProvision { get; set; }
        public decimal TotalContable { get; set; }
        public decimal DiferenciaTipoCambio { get; set; }
        public decimal TipoCambio { get; set; }

        public virtual ItemCp Pk { get; set; } = null!;
        public virtual ItemCpRetencion ItemCpRetencion { get; set; } = null!;
        public virtual ICollection<ItemCpCajaPago> ItemCpCajaPagos { get; set; }
    }
}
