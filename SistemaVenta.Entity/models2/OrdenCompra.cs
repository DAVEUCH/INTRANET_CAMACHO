using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class OrdenCompra
    {
        public int Pkid { get; set; }
        public int IdcpInventario { get; set; }
        public int IdmodalidadCredito { get; set; }
        public string IdconsolidadoOc { get; set; } = null!;
        public string DocIdentidad { get; set; } = null!;
        public string? EstadoEntrega { get; set; }
        public string? EstadoFacturacion { get; set; }
        public string? EstadoAprobacion { get; set; }
        public bool SaldoCancelado { get; set; }
        public bool Credito { get; set; }
        public DateTime FechaPago { get; set; }
        public bool ClienteDescriptivo { get; set; }
        public string Direccion { get; set; } = null!;
        public string DireccionEntrega { get; set; } = null!;
        public decimal MontoDctoPromocional { get; set; }
        public bool Cancelado { get; set; }
        public bool Consignacion { get; set; }
        public bool Consolidado { get; set; }
        public string FormaGeneracion { get; set; } = null!;
        public bool RequiereAprobacion { get; set; }
        public int Idincoterm { get; set; }
        public bool Importacion { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime? FechaAprobacion { get; set; }

        public virtual ConsolidadoOrdenesCompra IdconsolidadoOcNavigation { get; set; } = null!;
        public virtual Incoterm IdincotermNavigation { get; set; } = null!;
        public virtual Cp Pk { get; set; } = null!;
        public virtual OrdenCompra1 OrdenCompra1 { get; set; } = null!;
    }
}
