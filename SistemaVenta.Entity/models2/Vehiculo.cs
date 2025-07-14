using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Vehiculo
    {
        public Vehiculo()
        {
            AsignacionRutaZonaVehiculos = new HashSet<AsignacionRutaZonaVehiculo>();
            ConsolidadoCargas = new HashSet<ConsolidadoCarga>();
        }

        public int Pkid { get; set; }
        public int Idempleado { get; set; }
        public int Idproveedor { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public decimal CapacidadPeso { get; set; }
        public decimal CapacidadVolumen { get; set; }
        public string Modelo { get; set; } = null!;
        public string Marca { get; set; } = null!;
        public string Placa { get; set; } = null!;
        public string Placa2 { get; set; } = null!;
        public bool AplicaDistribucion { get; set; }
        public string CertificadoInscripcion { get; set; } = null!;

        public virtual Persona IdempleadoNavigation { get; set; } = null!;
        public virtual Persona IdproveedorNavigation { get; set; } = null!;
        public virtual ICollection<AsignacionRutaZonaVehiculo> AsignacionRutaZonaVehiculos { get; set; }
        public virtual ICollection<ConsolidadoCarga> ConsolidadoCargas { get; set; }
    }
}
