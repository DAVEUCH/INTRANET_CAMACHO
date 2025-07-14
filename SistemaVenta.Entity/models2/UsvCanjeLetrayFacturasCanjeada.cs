using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvCanjeLetrayFacturasCanjeada
    {
        public DateTime? FechaCanje { get; set; }
        public string Nombre { get; set; } = null!;
        public int FacId { get; set; }
        public string FacNumero { get; set; } = null!;
        public DateTime FacFecha { get; set; }
    }
}
