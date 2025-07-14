using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VCptoOperacion
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public bool Activo { get; set; }
        public string TipoCpAsociado { get; set; } = null!;
        public string CreadoPartirDe { get; set; } = null!;
        public string OrigenDestino { get; set; } = null!;
        public string? Detalle { get; set; }
        public bool Contabilizable { get; set; }
        public int Pkid { get; set; }
    }
}
