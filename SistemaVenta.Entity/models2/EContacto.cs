using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EContacto
    {
        public string ContactosId { get; set; } = null!;
        public string ContactosNombre { get; set; } = null!;
        public string ContactosCargo { get; set; } = null!;
        public string ContactosTelefono1 { get; set; } = null!;
        public string ContactosTelefono2 { get; set; } = null!;
        public string ContactosEmail { get; set; } = null!;
        public int Idpersona { get; set; }
        public string ContactosHorarioAtencion { get; set; } = null!;
        public DateTime ContactosFechaAniversario { get; set; }
        public DateTime ContactosFechaCumpleaños { get; set; }
    }
}
