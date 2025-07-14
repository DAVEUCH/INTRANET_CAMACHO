using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ConsolidadoOrdenesCompra
    {
        public ConsolidadoOrdenesCompra()
        {
            ItemsConsolidadoOrdenesCompras = new HashSet<ItemsConsolidadoOrdenesCompra>();
            OrdenCompras = new HashSet<OrdenCompra>();
        }

        public string Pkid { get; set; } = null!;
        public string NumCp { get; set; } = null!;
        public int Idproveedor { get; set; }
        public int Idmoneda { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public int IdtipoCp { get; set; }
        public bool Cancelado { get; set; }
        public string EstadoEntrega { get; set; } = null!;
        public string EstadoAprobacion { get; set; } = null!;
        public string EstadoFacturacion { get; set; } = null!;
        public bool? Prorateado { get; set; }
        public bool Credito { get; set; }
        public int IdmodalidadCredito { get; set; }
        public DateTime FechaPago { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<ItemsConsolidadoOrdenesCompra> ItemsConsolidadoOrdenesCompras { get; set; }
        public virtual ICollection<OrdenCompra> OrdenCompras { get; set; }
    }
}
