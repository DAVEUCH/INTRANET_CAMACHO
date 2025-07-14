using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptInformacionCpDetalleProductoNoConsolidado
    {
        public int Pkid { get; set; }
        public int Idcp { get; set; }
        public int Idproducto { get; set; }
        public int Idunidad { get; set; }
        public int Factor { get; set; }
        public int CantidadBase { get; set; }
        public decimal Cantidad { get; set; }
        public string Descripcion { get; set; } = null!;
        public int? TipoItemCp { get; set; }
        public decimal Total { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}
