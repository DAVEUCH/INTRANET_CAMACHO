using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EValorPorDefecto
    {
        public string Id { get; set; } = null!;
        public string IdtipoReferenciado { get; set; } = null!;
        public int Idusuario { get; set; }
        public string IddefValorPorDefecto { get; set; } = null!;
        public string IdposCursorCabecera { get; set; } = null!;
        public string IdposCursorDetalle { get; set; } = null!;
        public string IdposCursorDetalle2 { get; set; } = null!;
    }
}
