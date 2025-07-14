using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VSelCpVentaEnvioLibroElectronico
    {
        public int Id { get; set; }
        public string NumCp { get; set; } = null!;
        public string? PersonaNombre { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public int Idejercicio { get; set; }
        public string Mes { get; set; } = null!;
        public bool Anulado { get; set; }
    }
}
