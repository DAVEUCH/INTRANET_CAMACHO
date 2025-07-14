using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EConfiguracionRelacion
    {
        public int Id { get; set; }
        public string IdtipoOrigen { get; set; } = null!;
        public string IdtipoDestino { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string BalanceOrigenA { get; set; } = null!;
        public string BalanceOrigenB { get; set; } = null!;
        public string PropiedadReferencia { get; set; } = null!;
        public string PropiedadBalance { get; set; } = null!;
        public string TipoRelacion { get; set; } = null!;
    }
}
