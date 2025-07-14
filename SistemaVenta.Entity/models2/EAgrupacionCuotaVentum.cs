using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EAgrupacionCuotaVentum
    {
        public int AgrupacionesId { get; set; }
        public int IdcuotaVenta { get; set; }
        public string AgrupacionesDescripcion { get; set; } = null!;
        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;
    }
}
