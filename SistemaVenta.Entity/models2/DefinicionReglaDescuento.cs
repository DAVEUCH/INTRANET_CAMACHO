using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class DefinicionReglaDescuento
    {
        public int Pkid { get; set; }
        public int IddefinicionDescuento { get; set; }
        public string RutaCaracteristicaEstructural { get; set; } = null!;
        public string RutaAtributoBusqueda { get; set; } = null!;
        public string Condicion { get; set; } = null!;
        public string ValorEnTexto { get; set; } = null!;
        public string Enlace { get; set; } = null!;

        public virtual DefinicionDescuento IddefinicionDescuentoNavigation { get; set; } = null!;
    }
}
