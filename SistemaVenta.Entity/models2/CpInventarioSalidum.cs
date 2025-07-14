using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CpInventarioSalidum
    {
        public int Pkid { get; set; }
        public int IdcpInventario { get; set; }
        public string? EstadoFacturacion { get; set; }
        public string? EstadoDevolucion { get; set; }
        public string NumeroOrdenCompra { get; set; } = null!;
        public string DireccionEntrega { get; set; } = null!;
        public int Idvehiculo { get; set; }
        public bool RequiereTransportista { get; set; }
        public string EstadoEntregaDevolucion { get; set; } = null!;
        public int Idvehiculo2 { get; set; }
        public string DireccionTransportista { get; set; } = null!;
        public string DireccionTransportista2 { get; set; } = null!;
        public string DocIdentidad { get; set; } = null!;
        public string? NombreChofer { get; set; }
        public string? NombreProveedorVehiculo { get; set; }
        public string? PlacaVehiculo { get; set; }
        public string? Placa2Vehiculo { get; set; }
        public string? CertificadoVehiculo { get; set; }
        public string? ModeloVehiculo { get; set; }
        public string? MarcaVehiculo { get; set; }
        public int? IddireccionEntrega { get; set; }

        public virtual CpInventario IdcpInventarioNavigation { get; set; } = null!;
        public virtual Cp Pk { get; set; } = null!;
    }
}
