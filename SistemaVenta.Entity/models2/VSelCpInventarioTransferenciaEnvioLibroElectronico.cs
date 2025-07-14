using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VSelCpInventarioTransferenciaEnvioLibroElectronico
    {
        public int Id { get; set; }
        public string NumCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public string AlmacenEntrada { get; set; } = null!;
        public string AlmacenSalida { get; set; } = null!;
        public int Idejercicio { get; set; }
        public string Mes { get; set; } = null!;
    }
}
