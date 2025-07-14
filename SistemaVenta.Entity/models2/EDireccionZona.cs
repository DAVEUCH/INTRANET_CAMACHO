using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EDireccionZona
    {
        public int Idzona { get; set; }
        public int Iddireccion { get; set; }
        public int DireccionZonasId { get; set; }
        public int DireccionZonasIddireccion { get; set; }
        public int DireccionZonasIdzona { get; set; }
        public int DireccionZonasIdcliente { get; set; }
        public int DireccionIddireccion { get; set; }
        public int DireccionesIddireccion { get; set; }
        public int DireccionesIdcliente { get; set; }
        public int DireccionesIdzona { get; set; }
        public int DireccionesId { get; set; }
        public int DireccionesZonaId { get; set; }
        public int DireccionesZonaIdzona { get; set; }
        public int DireccionesZonaIdcliente { get; set; }
        public int DireccionesZonaIddireccion { get; set; }
        public int DireccionesZonaOrdenVisita { get; set; }
        public int DireccionZonasOrdenVisita { get; set; }
        public int Idcliente { get; set; }
        public string Descripcion { get; set; } = null!;
    }
}
