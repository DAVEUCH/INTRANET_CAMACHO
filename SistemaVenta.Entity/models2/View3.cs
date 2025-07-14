using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class View3
    {
        public int Pkid { get; set; }
        public int IdcpInventario { get; set; }
        public string DocIdentidad { get; set; } = null!;
        public string EstadoEntrega { get; set; } = null!;
        public bool ClienteDescriptivo { get; set; }
        public string Direccion { get; set; } = null!;
        public string DireccionEntrega { get; set; } = null!;
        public string? EstadoDevolucion { get; set; }
        public string? EstadoEntregaDevolucion { get; set; }
        public string? EstadoDescuento { get; set; }
        public bool VentaEspecial { get; set; }
        public bool EscalaPreferencial { get; set; }
        public string NumeroOrdenCompra { get; set; } = null!;
        public decimal EfectivoRestringido { get; set; }
        public bool AplicaDistribucion { get; set; }
        public bool OmitirPoliticasCredito { get; set; }
        public int Idcliente2 { get; set; }
    }
}
