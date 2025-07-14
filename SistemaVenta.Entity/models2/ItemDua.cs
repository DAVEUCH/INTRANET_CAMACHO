using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemDua
    {
        public int Pkid { get; set; }
        public decimal CantidadAentregar { get; set; }
        public decimal ValorIncoterm { get; set; }
        public decimal ValorFlete { get; set; }
        public decimal ValorSeguro { get; set; }
        public decimal ValorCif { get; set; }
        public decimal ValorAjuste { get; set; }
        public decimal ValorAduana { get; set; }
        public decimal PorcentajeImpuestoDua { get; set; }
        public int BalanceImportacion { get; set; }
        public decimal MontoArancel { get; set; }
        public decimal MontoImpuesto { get; set; }
        public decimal TotalCif { get; set; }
        public decimal TotalIncoterm { get; set; }
        public decimal PorcentajePercepcion { get; set; }
        public decimal TotalIgv { get; set; }
        public decimal TotalFob { get; set; }
        public decimal TotalPercepcion { get; set; }
        public decimal TotalServicioDespacho { get; set; }
        public decimal TotalArancel { get; set; }
        public decimal ValorServicioDespacho { get; set; }
        public decimal ValorFob { get; set; }

        public virtual ItemCp Pk { get; set; } = null!;
    }
}
