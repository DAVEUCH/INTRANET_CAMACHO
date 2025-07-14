using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoVehiculo
    {
        public int VehiculoId { get; set; }
        public string VehiculoCodigo { get; set; } = null!;
        public string VehiculoNombre { get; set; } = null!;
        public string VehiculoModelo { get; set; } = null!;
        public string VehiculoMarca { get; set; } = null!;
        public string VehiculoPlaca { get; set; } = null!;
        public string VehiculoPlaca2 { get; set; } = null!;
        public decimal VehiculoCapacidadPeso { get; set; }
        public decimal VehiculoCapacidadVolumen { get; set; }
        public string TransportistaCodigo { get; set; } = null!;
        public string TransportistaNombre { get; set; } = null!;
        public string TransportistaRuc { get; set; } = null!;
        public string ChoferCodigo { get; set; } = null!;
        public string ChoferNombre { get; set; } = null!;
        public string ChoferDocumentoIdentidad { get; set; } = null!;
        public string ChoferLicenciaConducir { get; set; } = null!;
        public int ProveedorId { get; set; }
        public int ProveedorDireccionId { get; set; }
        public string ProveedorDireccion { get; set; } = null!;
        public string ProveedorDireccionDistrito { get; set; } = null!;
        public string ProveedorDireccionProvincia { get; set; } = null!;
        public string ProveedorDireccionDepartamento { get; set; } = null!;
    }
}
