using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EListaInventario
    {
        public int Id { get; set; }
        public string NumCp { get; set; } = null!;
        public int IdresponsableConteo { get; set; }
        public int IdtipoCp { get; set; }
        public int Idalmacen { get; set; }
        public DateTime Fecha { get; set; }
        public int Idsucursal { get; set; }
        public int IdresponsableReconteo { get; set; }
        public int IdresponsableDigitador { get; set; }
        public string Observacion { get; set; } = null!;
        public string UnidadConteo { get; set; } = null!;
    }
}
