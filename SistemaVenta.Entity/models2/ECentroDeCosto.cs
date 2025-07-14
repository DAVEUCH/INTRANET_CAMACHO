using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECentroDeCosto
    {
        public int Id { get; set; }
        public int IdcentroDeCostoPadre { get; set; }
        public int IdplanCuentas { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int Nivel { get; set; }
        public bool Activo { get; set; }
    }
}
