using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VListaPrecios2Xml
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;
        public string TipoEntidad { get; set; } = null!;
        public int Idsucursal { get; set; }
        public int Idcliente { get; set; }
        public int IdcategoriaCliente { get; set; }
        public int Idmoneda { get; set; }
        public bool PorDefecto { get; set; }
        public bool Activo { get; set; }
    }
}
