using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Zona
    {
        public Zona()
        {
            CpDistribucionIdzonaRepartoNavigations = new HashSet<CpDistribucion>();
            CpDistribucionIdzonaVentaNavigations = new HashSet<CpDistribucion>();
            DireccionZonas = new HashSet<DireccionZona>();
            FuerzaVentasZonas = new HashSet<FuerzaVentasZona>();
            ZonaRutaVehiculos = new HashSet<ZonaRutaVehiculo>();
            ZonaRutaVendedors = new HashSet<ZonaRutaVendedor>();
            ZonaVehiculos = new HashSet<ZonaVehiculo>();
            ZonaVendedors = new HashSet<ZonaVendedor>();
        }

        public int Pkid { get; set; }
        public int IdzonaPadre { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public bool Activo { get; set; }
        public int Nivel { get; set; }
        public bool SubZonas { get; set; }
        public string CodigoPostal { get; set; } = null!;
        public bool Venta { get; set; }
        public bool Reparto { get; set; }
        public bool GestionaRecargos { get; set; }
        public decimal PorcentajeRecargo { get; set; }

        public virtual ICollection<CpDistribucion> CpDistribucionIdzonaRepartoNavigations { get; set; }
        public virtual ICollection<CpDistribucion> CpDistribucionIdzonaVentaNavigations { get; set; }
        public virtual ICollection<DireccionZona> DireccionZonas { get; set; }
        public virtual ICollection<FuerzaVentasZona> FuerzaVentasZonas { get; set; }
        public virtual ICollection<ZonaRutaVehiculo> ZonaRutaVehiculos { get; set; }
        public virtual ICollection<ZonaRutaVendedor> ZonaRutaVendedors { get; set; }
        public virtual ICollection<ZonaVehiculo> ZonaVehiculos { get; set; }
        public virtual ICollection<ZonaVendedor> ZonaVendedors { get; set; }
    }
}
