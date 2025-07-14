using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class View1
    {
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Abreviacion { get; set; } = null!;
        public int Numero { get; set; }
        public int LongitudNumero { get; set; }
        public string Serie { get; set; } = null!;
        public int LongitudSerie { get; set; }
        public string? Sucursal { get; set; }
        public string? TipoMov { get; set; }
        public bool PermitirFechasFuturas { get; set; }
    }
}
