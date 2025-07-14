using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EClaseProductoServicio
    {
        public string CodigoClase { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int Nivel { get; set; }
        public bool TieneSubClases { get; set; }
        public string TipoProductoServicio { get; set; } = null!;
        public bool Activo { get; set; }
        public int Id { get; set; }
        public int IdclaseProductoServicioPadre { get; set; }
        public bool TieneProductoServicioAsociado { get; set; }
        public int IdtipoCaracteristica1 { get; set; }
        public int IdtipoCaracteristica2 { get; set; }
        public int IdtipoCaracteristica3 { get; set; }
        public int IdtipoCaracteristica4 { get; set; }
        public int IdtipoCaracteristica5 { get; set; }
        public int IdtipoCaracteristica6 { get; set; }
        public int IdtipoCaracteristica7 { get; set; }
        public int IdtipoCaracteristica8 { get; set; }
        public int IdtipoCaracteristica9 { get; set; }
        public int IdtipoCaracteristica10 { get; set; }
    }
}
