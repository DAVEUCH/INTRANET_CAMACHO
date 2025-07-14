using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Cotizacion
    {
        public int Pkid { get; set; }
        public int IdmodalidadCredito { get; set; }
        public string DocIdentidad { get; set; } = null!;
        public bool EstadoAceptacion { get; set; }
        public string EstadoAtencion { get; set; } = null!;
        public bool EstadoAprobacion { get; set; }
        public bool Credito { get; set; }
        public bool ClienteDescriptivo { get; set; }
        public string EstadoFacturacion { get; set; } = null!;
        public bool EscalaPreferencial { get; set; }
        public DateTime FechaPago { get; set; }
        public int TiempoValidez { get; set; }
        public string? NumeroOrdenCompra { get; set; }
        public int IdcpInventario { get; set; }
        public string Direccion { get; set; } = null!;
        public string DireccionEntrega { get; set; } = null!;

        public virtual Cp Pk { get; set; } = null!;
    }
}
