using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EUnidadItemListaPrecio
    {
        public int UnidadesId { get; set; }
        public int UnidadesIdunidad { get; set; }
        public string UnidadesFormatoVenta { get; set; } = null!;
        public bool UnidadesModificado { get; set; }
        public bool UnidadesPredeterminado { get; set; }
        public bool UnidadesPermitirDecimales { get; set; }
        public int IditemListaPrecios { get; set; }
        public int Id { get; set; }
        public int Idunidad { get; set; }
        public string FormatoVenta { get; set; } = null!;
        public bool Modificado { get; set; }
        public bool Predeterminado { get; set; }
        public bool PermitirDecimales { get; set; }
    }
}
