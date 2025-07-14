using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteVerificacionAsignacionZonaRepartoVehiculo
    {
        public DateTime Fecha { get; set; }
        public DateTime FechaEmision { get; set; }
        public string Numero { get; set; } = null!;
        public string PersonaNombre { get; set; } = null!;
        public decimal Total { get; set; }
        public string? Consolidado { get; set; }
        public string? Vehiculo { get; set; }
        public string Pedido { get; set; } = null!;
        public string? NombreVehiculo { get; set; }
    }
}
