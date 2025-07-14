using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class GcSucursalFe
    {
        public int? Pkid { get; set; }
        public string? Nombre { get; set; }
        public int? Activo { get; set; }
        public string? Codigo { get; set; }
        public string? Direccion { get; set; }
        public string? PuntoEmision { get; set; }
        public string? EspecialidadL1 { get; set; }
        public string? EspecialidadL2 { get; set; }
        public string? DatosContactar { get; set; }
        public string? RutaFactus { get; set; }
        public string? NombreImpresora { get; set; }
        public string? PlantillaFormato { get; set; }
        public string? EmailTdaSucursal { get; set; }
        public string? EmailCajaSucursal { get; set; }
        public string? CodigoEstable { get; set; }
    }
}
