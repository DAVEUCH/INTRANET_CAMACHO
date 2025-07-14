using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Pedido
    {
        public int Pkid { get; set; }
        public int IdcpInventario { get; set; }
        public int IdtipoMedioDePago { get; set; }
        public int IdmodalidadCredito { get; set; }
        public string DocIdentidad { get; set; } = null!;
        public string? EstadoEntrega { get; set; }
        public string? EstadoFacturacion { get; set; }
        public string EstadoAprobacion { get; set; } = null!;
        public bool SaldoCancelado { get; set; }
        public bool Credito { get; set; }
        public DateTime FechaPago { get; set; }
        public bool ClienteDescriptivo { get; set; }
        public string Direccion { get; set; } = null!;
        public decimal MontoDctoPromocional { get; set; }
        public string DireccionEntrega { get; set; } = null!;
        public bool Cancelado { get; set; }
        public bool VentaEspecial { get; set; }
        public bool EscalaPreferencial { get; set; }
        public string NumeroOrdenCompra { get; set; } = null!;
        public bool PagoEfectivo { get; set; }
        public bool RequiereAprobacion { get; set; }
        public decimal EfectivoRestringido { get; set; }
        public bool AplicaDistribucion { get; set; }
        public bool OmitirPoliticasCredito { get; set; }
        public DateTime FechaEntrega { get; set; }
        public bool Ajustado { get; set; }
        public int Idcliente2 { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public int IdgrupoVentas { get; set; }
        public int? IddireccionEntrega { get; set; }
        public int? IddireccionCliente { get; set; }

        public virtual CpInventario IdcpInventarioNavigation { get; set; } = null!;
        public virtual Cp Pk { get; set; } = null!;
        public virtual PedidoFreddy PedidoFreddy { get; set; } = null!;
    }
}
