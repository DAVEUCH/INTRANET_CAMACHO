using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EFreddyCambioEstado
    {
        public int Id { get; set; }
        public int? Identidad { get; set; }
        public int? Idestado { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Idusuario { get; set; }
        public bool? Activado { get; set; }
        public string? IdtipoEntidad { get; set; }
        public string? Hora { get; set; }
    }
}
