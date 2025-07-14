using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VSelCpInventarioEntradaEnvioLibroElectronico
    {
        public int Id { get; set; }
        public string NumCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string? PersonaNombre { get; set; }
        public decimal Total { get; set; }
        public string EstadoFacturacion { get; set; } = null!;
        public string NumDocOrigen { get; set; } = null!;
        public int Idejercicio { get; set; }
        public string Mes { get; set; } = null!;
        public int Idcp { get; set; }
    }
}
