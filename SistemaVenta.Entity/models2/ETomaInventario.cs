using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ETomaInventario
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string NumCp { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int Idalmacen { get; set; }
        public int Idresponsable { get; set; }
        public int IdtipoCp { get; set; }
        public int Idsucursal { get; set; }
        public int Idmoneda { get; set; }
        public bool CerrarToma { get; set; }
        public string? TipoUnidad { get; set; }
    }
}
