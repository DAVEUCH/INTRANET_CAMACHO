using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VvalCpCajaSinMedioDePago
    {
        public int Pkid { get; set; }
        public string NumCp { get; set; } = null!;
        public string Abreviacion { get; set; } = null!;
        public string TipoCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
    }
}
