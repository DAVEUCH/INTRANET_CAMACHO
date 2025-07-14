using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvGuiasSalidasCabecera
    {
        public int GuiaId { get; set; }
        public string GuiaTdoc { get; set; } = null!;
        public string GuiaNro { get; set; } = null!;
        public string? GuiaFechaEmision { get; set; }
        public string? GuiaHoraEmision { get; set; }
        public string GuiaMoneda { get; set; } = null!;
        public decimal GuiaTotal { get; set; }
        public string? Cliente { get; set; }
        public string SucursalNombre { get; set; } = null!;
        public string DireccionEntrega { get; set; } = null!;
    }
}
