using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvPercepcionCliente
    {
        public int Pkid { get; set; }
        public int IdtipoCp { get; set; }
        public string NumCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string? PersonaNombre { get; set; }
        public int Idpersona { get; set; }
        public decimal MontoPercepcion { get; set; }
        public bool Anulado { get; set; }
    }
}
