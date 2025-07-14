using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EAlmacen
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public bool Activo { get; set; }
        public int Idsucursal { get; set; }
        public bool RecepcionDistribuida { get; set; }
        public bool RecepcionCentralizada { get; set; }
        public bool EsTransito { get; set; }
        public bool Importacion { get; set; }
        public bool SugerenciaCompra { get; set; }
        public string Direccion { get; set; } = null!;
        public bool GestionaCostoPromedio { get; set; }
    }
}
