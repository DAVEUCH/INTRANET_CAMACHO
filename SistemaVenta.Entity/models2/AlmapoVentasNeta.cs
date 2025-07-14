using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class AlmapoVentasNeta
    {
        public int ProveedorId { get; set; }
        public int SucursalId { get; set; }
        public decimal? TotalItem { get; set; }
        public int EjercioId { get; set; }
        public int PeriodoId { get; set; }
        public int Idpersona { get; set; }
    }
}
