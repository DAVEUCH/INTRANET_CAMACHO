using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Proveedor
    {
        public Proveedor()
        {
            ProveedorAuspiciadors = new HashSet<ProveedorAuspiciador>();
        }

        public int Pkid { get; set; }
        public int Idmoneda { get; set; }
        public decimal LineaCredito { get; set; }
        public decimal BalanceSoles { get; set; }
        public decimal BalanceDolares { get; set; }
        public int IdmodalidadCredito { get; set; }
        public int DiasCredito { get; set; }
        public bool Restrictivo { get; set; }
        public string IdmonedaListaPrecio { get; set; } = null!;
        public bool EntregaDistribuida { get; set; }
        public bool EntregaCentralizada { get; set; }
        public bool ProveedorGiro { get; set; }
        public bool CreditoContado { get; set; }
        public int IdtipoMedioDePago { get; set; }
        public int Relacionada { get; set; }

        public virtual ICollection<ProveedorAuspiciador> ProveedorAuspiciadors { get; set; }
    }
}
