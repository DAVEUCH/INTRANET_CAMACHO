using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CpInventarioTransferencium
    {
        public int Pkid { get; set; }
        public int IdcpInventarioSalida { get; set; }
        public int IdcpInventarioEntrada { get; set; }
        public string NumDocOrigen { get; set; } = null!;
        public string EstadoRecepcion { get; set; } = null!;
        public string Idvehiculo { get; set; } = null!;
        public bool RequiereTransportista { get; set; }
        public string? EstadoNacionalizacion { get; set; }
        public bool? Importacion { get; set; }
        public string NombreChofer { get; set; } = null!;
        public string NombreProveedorVehiculo { get; set; } = null!;
        public string PlacaVehiculo { get; set; } = null!;
        public string Placa2Vehiculo { get; set; } = null!;
        public string CertificadoVehiculo { get; set; } = null!;
        public string ModeloVehiculo { get; set; } = null!;
        public string MarcaVehiculo { get; set; } = null!;

        public virtual CpInventario IdcpInventarioEntradaNavigation { get; set; } = null!;
        public virtual CpInventario IdcpInventarioSalidaNavigation { get; set; } = null!;
        public virtual Cp Pk { get; set; } = null!;
    }
}
